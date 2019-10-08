﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using E4S.Data;
using E4S.Models;
using E4S.Models.AccountInventory;
using E4S.ViewModel.AccountVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E4S.Controllers.AccountInventory
{
  [Authorize]
  public class QuoteController : Controller
    {
    [TempData]
    public string StatusMessage { get; set; }

    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public QuoteController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
      _context = context;
      _userManager = userManager;

    }
    private Guid getOrg()
    {
      var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
      var orgId = _context.Users.Where(x => x.Id == userId).FirstOrDefault().OrganisationId;

      var orgdetails = _context.Organisations.Where(x => x.Id == orgId).FirstOrDefault();
      ViewData["OrganisationName"] = orgdetails.OrganisationName;
      ViewData["OrganisationImage"] = orgdetails.ImageUrl;

      return orgId;
    }
    // GET: /<controller>/
    public IActionResult Index()
        {
      var orgId = getOrg();
      var allquotes = _context.QuoteRecords.Where(x => x.OrganisationId == orgId).Where(x => x.DateCreated.Month == DateTime.Now.Month).OrderByDescending(x => x.DateCreated).ToList();
      var customer = _context.Customers.Where(x => x.OrganisationId == orgId).ToList();

      ViewData["StatusMessage"] = StatusMessage;

      List<QuoteListViewModel> listQVM = new List<QuoteListViewModel>();
      QuoteListViewModel qVM;

      foreach (var item in allquotes)
      {
        qVM = new QuoteListViewModel();
        qVM.QuoteRecord = item;
        qVM.Customer = customer.Where(x => x.Id == item.CustomerId).FirstOrDefault();

        listQVM.Add(qVM);
      }



      return View(listQVM.OrderByDescending(x => x.QuoteRecord.DateCreated));
        }

    public IActionResult ConvertToInvoice(Guid id)
    {
      var orgId = getOrg();
      var inv = _context.InvoiceRecords.Where(x => x.OrganisationId == orgId).OrderByDescending(x => x.DateCreated).ToList();

      var quote = _context.QuoteRecords.Where(x => x.Id == id).FirstOrDefault();
      var quoteList = _context.QuoteItems.Where(x => x.QuoteRecordId == id).ToList();
      InvoiceRecord inR = new InvoiceRecord()
      {
        Id = Guid.NewGuid(),
        CustomerId = quote.CustomerId,
        QuoteNo = quote.QuoteNo,
        OrganisationId = orgId,
        SubTotal = quote.SubTotal,
        Tax = quote.Tax,
        Total = quote.Total
        
      };

      if (inv.Count > 0)
      {
        inR.InvoiceNo = inv.FirstOrDefault().InvoiceNo + 1;
      }
      else
      {
        inR.InvoiceNo = 1;
      }

      _context.Add(inR);
      _context.SaveChanges();


      InvoiceItem invoiceItem;
      
      foreach (var item in quoteList)
      {

        invoiceItem = new InvoiceItem()
        {
          Id = Guid.NewGuid(),
          InvoiceRecordId = inR.Id,
          OrganisationId = orgId,
          ProductServiceId = item.ProductServiceId,
          Quantity = item.Quantity,
          UnitCost = item.UnitCost,
          TotalCost = item.TotalCost,
          
        };

        _context.Add(invoiceItem);
        _context.SaveChanges();
      }


      StatusMessage = "Conversion successful. Check your Invoice List.";
      return RedirectToAction("Index");

    }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> AddCustomer(Customer customer)
        //{
        //    var orgId = getOrg();

        //    if (ModelState.IsValid)
        //    {
        //        customer.Id = Guid.NewGuid();
        //        customer.OrganisationId = orgId;


        //        _context.Add(customer);
        //        await _context.SaveChangesAsync();

        //        StatusMessage = "New Customer successfully created.";
        //        return RedirectToAction(nameof(Index));
        //    }

        //    StatusMessage = "Error! Check fields...";
        //    ViewData["StatusMessage"] = StatusMessage;

        //    return View(customer);
        //}


        [HttpPost]
        public async Task<IActionResult> AddCustomer([FromBody]Customer customer)
        {
            var orgId = getOrg();

            if (customer != null)
            {
                customer.Id = Guid.NewGuid();
                customer.OrganisationId = orgId;


                try
                {
                    _context.Add(customer);
                    await _context.SaveChangesAsync();

                    return Json(new
                    {
                        msg = "Success"
                    });

                }
                catch
                {
                    return Json(new
                    {
                        msg = "Failed"
                    });

                }


                //StatusMessage = "New Vendor successfully created.";
            }

            //StatusMessage = "Error! Check fields...";
            //ViewData["StatusMessage"] = StatusMessage;
            return Json(new
            {
                msg = "No Data"
            });

        }















        [HttpPost]
    public IActionResult GetCustomer([FromBody]AutoCus tag)
    {
      var orgId = getOrg();

      var customer = _context.Customers.Where(x => x.OrganisationId == orgId).Where(x => x.CustomerName == tag.Name).FirstOrDefault();
      if(customer != null)
      {
        var quoterec = _context.QuoteRecords.Where(x => x.Id == tag.QuoteId).FirstOrDefault();

        quoterec.CustomerId = customer.Id;

        //quoterec.QuoteNo = 0;

        _context.Update(quoterec);
        _context.SaveChanges();
      }
      
      return Json(customer);

    }

    [HttpPost]
    public async Task<IActionResult> AddProduct([FromBody]QuoteItem quoteItem)
    {
      var orgId = getOrg();

      if (quoteItem != null)
      {

        quoteItem.Id = Guid.NewGuid();
        quoteItem.OrganisationId = orgId;

        quoteItem.TotalCost = quoteItem.UnitCost * quoteItem.Quantity;


        try
        {
          _context.Add(quoteItem);
          _context.SaveChanges();

          var items = _context.QuoteItems.Where(x => x.QuoteRecordId == quoteItem.QuoteRecordId).ToList();
          var qr = _context.QuoteRecords.Where(x => x.Id == quoteItem.QuoteRecordId).FirstOrDefault();

          qr.SubTotal = items.Sum(x => x.TotalCost);
          qr.Tax = qr.SubTotal * 0.05f;
          qr.Total = qr.SubTotal + qr.Tax;

          _context.Update(qr);
          _context.SaveChanges();

          return Json(new
          {
            msg = "Success"
          });

        }
        catch
        {
          return Json(new
          {
            msg = "Failed"
          });

        }


        //StatusMessage = "New Vendor successfully created.";
      }

      //StatusMessage = "Error! Check fields...";
      //ViewData["StatusMessage"] = StatusMessage;
      return Json(new
      {
        msg = "No Data"
      });

    }

    //  public IActionResult AddQuote()
    //  {
    //var orgId = getOrg();
    //QuoteRecord qr = new QuoteRecord()
    //{
    //  Id = Guid.NewGuid(),
    //  OrganisationId = orgId

    //};
    //try
    //{
    //  _context.Add(qr);
    //  _context.SaveChanges();


    //  return RedirectToAction("AddQuote", new { id = qr.Id });
    //}
    //catch
    //{

    //}


    //return View();
    //  }

    public IActionResult AddQuote(Guid? id)
    {
      var orgId = getOrg();
      var quo = _context.QuoteRecords.Where(x => x.OrganisationId == orgId).OrderByDescending(x => x.DateCreated).ToList();



      if(id == null)
      {
        QuoteRecord qr = new QuoteRecord()
        {
          Id = Guid.NewGuid(),
          OrganisationId = orgId

        };

        if(quo.Count > 0)
        {
          qr.QuoteNo = quo.FirstOrDefault().QuoteNo + 1;
        }
        else
        {
          qr.QuoteNo = 1;
        }

        _context.Add(qr);
        _context.SaveChanges();


        id = qr.Id;

        return RedirectToAction("AddQuote", new { id = qr.Id });

      }
      var cQuoteRecord = quo.Where(x => x.Id == id).FirstOrDefault();

      QuoteViewModel qVM = new QuoteViewModel();

      qVM.Id = cQuoteRecord.Id;
      qVM.QuoteNo = cQuoteRecord.QuoteNo;
      qVM.Customer = _context.Customers.Where(x => x.Id == cQuoteRecord.CustomerId).FirstOrDefault();
      qVM.Organisation = _context.Organisations.Where(x => x.Id == orgId).FirstOrDefault();
      qVM.Tax = cQuoteRecord.Tax;
      qVM.SubTotal = cQuoteRecord.SubTotal;
      qVM.Total = cQuoteRecord.Total;
      qVM.QuoteItems = _context.QuoteItems.Where(x => x.QuoteRecordId == id).Include(x => x.ProductService).ToList();
      qVM.DateCreated = cQuoteRecord.DateCreated;
      //qVM.SubTotal = cQuoteRecord.SubTotal;
      //qVM.Tax = cQuoteRecord.Tax;
      //qVM.Total = cQuoteRecord.Total;

      return View(qVM);
    }
    }

  public class AutoCus
  {
    public string Name { get; set; }
    public Guid QuoteId { get; set; }
  }
}
