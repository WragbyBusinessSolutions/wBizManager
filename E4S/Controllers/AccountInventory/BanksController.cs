using System;
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

namespace E4S.Controllers.AccountInventory
{
  [Authorize]
  public class BanksController : Controller
    {
    [TempData]
    public string StatusMessage { get; set; }

    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public BanksController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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
    public IActionResult Index()
        {
      var orgId = getOrg();

      var accountBank = _context.AccountBanks.Where(x => x.OrganisationId == orgId).OrderByDescending(x => x.DateCreated).ToList();
      return View(accountBank);
        }

    [HttpPost]
    public async Task<IActionResult> AddAccount([FromBody]AccountBank accountBank)
    {
      var orgId = getOrg();

      if (accountBank != null)
      {
        accountBank.Id = Guid.NewGuid();
        accountBank.OrganisationId = orgId;


        try
        {
          _context.Add(accountBank);
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


        //[HttpPost]
        //public async Task<IActionResult> editAccount([FromBody]AccountBankVM accountBankVM)
        //{
        //    if (accountBankVM == null)
        //    {
        //        return Json(new
        //        {
        //            msg = "No Data"
        //        }
        //       );
        //    }

        //    var orgId = getOrg();
        //    var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();


        //    try
        //    {

        //        var newAcc = _context.AccountBanks.Where(x => x.Id == Guid.Parse(accountBankVM.AId)).FirstOrDefault();
        //        newAcc.AccountType = accountBankVM.AccountType;
        //        newAcc.AccountName = accountBankVM.AccountName;
        //        newAcc.AccountNo = accountBankVM.AccountNo;
        //        newAcc.BankName = accountBankVM.BankName;
        //        newAcc.Description = accountBankVM.Description;


        //        _context.Update(newAcc);
        //        _context.SaveChanges();


        //        return Json(new
        //        {
        //            msg = "Success"
        //        }
        //     );
        //    }
        //    catch (Exception ee)
        //    {

        //    }

        //    return Json(
        //    new
        //    {
        //        msg = "Fail"
        //    });
        //}



        public async Task<IActionResult> EditAccount(Guid id)
        {
            var orgId = getOrg();

            if (id == null)
            {
                return NotFound();
            }

            var accbnk = await _context.AccountBanks.FindAsync(id);
            if (accbnk == null)
            {
                return NotFound();
            }
            return View(accbnk);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAccount(AccountBank accountBank)
        {
            if (accountBank.Id == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountBank);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(accountBank.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                StatusMessage = "Customer record updated.";

                return RedirectToAction(nameof(Index));
            }
            return View(accountBank);
        }


        private bool AccountExists(Guid id)
        {
            return _context.AccountBanks.Any(e => e.Id == id);
        }

        [HttpPost]
        public IActionResult DeleteAccount([FromBody]string bankId)
        {
            if (bankId == null)
            {
                return Json(new
                {
                    msg = "No Data"
                }
               );
            }

            try
            {
                var accbnk = _context.AccountBanks.SingleOrDefault(m => m.Id == Guid.Parse(bankId));
                _context.AccountBanks.Remove(accbnk);
                _context.SaveChanges();

                return Json(new
                {
                    msg = "Success"
                });

            }
            catch
            {

            }

            return Json(new
            {
                msg = "Fail"
            });


        }




    }
}