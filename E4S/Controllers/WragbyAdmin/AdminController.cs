using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using E4S.Data;
using E4S.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BizManager.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using BizManager.Models.WragbyAdmin;
using BizManager.ViewModel.WragbyAdminViewModel;
using Microsoft.AspNetCore.Authorization;

namespace E4S.Controllers.WragbyAdmin
{
  [Authorize(Roles = "Super Admin, Wragby Admin")]
  public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private Guid orgId;

        public AdminController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

       
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CompanyListing()
        {
        
            var orgdetails = _context.Organisations.ToList();
         

            return View(orgdetails);
        }

        public IActionResult UpdateOrganizationDetails(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }        

            var orgdel = _context.Organisations.FirstOrDefault(x => x.Id == id);
            var orguser = _context.Users.Where(x => x.OrganisationId == id).ToList();

            ViewOrganisationDetails viewOrganisationDetails = new ViewOrganisationDetails();


            return View(viewOrganisationDetails);
        }

        public IActionResult Support()
        {
            return View();
        }

        public IActionResult SupportDetails()
        {
            return View();
        }

        public IActionResult License()
        {
      var batches = _context.BatchLKs;
      var lic = _context.Licenses;

      List<BatchListViewModel> blVM = new List<BatchListViewModel>();
      BatchListViewModel newblVM;

      foreach (var item in batches)
      {
        newblVM = new BatchListViewModel()
        {
          BatchLK = item,
          ConsumedLicense = lic.Where(x => x.BatchLKId == item.Id).Where(x => x.UserEmail == "").Count()
        };

        blVM.Add(newblVM);
      }

      ViewData["LicenseType"] = new SelectList(_context.LicenseTypes, "Id", "LicenseTypeName");

      return View(blVM);
        }

    [HttpPost]
    public IActionResult CreateLicence([FromBody] LicenseBatchViewModel lbVM)
    {
      if (lbVM == null)
      {
        return Json(new
        {
          msg = "No Data"
        });

      }


      BatchLK batchLK = new BatchLK()
      {
        Id = Guid.NewGuid(),
        BatchName = lbVM.BatchName,
        BatchDescription = lbVM.BundleDescription,
        BatchExpiryDate = lbVM.ExpirationDate,
        LicenseTypeId = lbVM.LicenseTypeId,
        NoOfDays = lbVM.LicenseDays,
        NoOfLicense = lbVM.NoOfLicense,
        Price = lbVM.LicensePrice,
        Status = "Active"
      };

      try
      {
        _context.Add(batchLK);
        _context.SaveChanges();
      }
      catch
      {
        return Json(new
        {
          msg = "Failed"
        });

      }

      List<License> licenses = new List<License>();
      License license;

      for (int i = 0; i < batchLK.NoOfLicense; i++)
      {
        license = new License()
        {
          Id = Guid.NewGuid(),
          LicenseKey = GenerateLicence(),
          BatchLKId = batchLK.Id
        };

        licenses.Add(license);

      }


      try
      {
        _context.Licenses.AddRange(licenses);
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
        msg = "Failed"
      });


    }


    public string GenerateLicence()
    {
      string lc = GetRandomHexNumber(5);

      for (int i = 0; i < 4; i++)
      {
        string adl = GetRandomHexNumber(5);
        lc = lc + "-" + adl;

      }
      return lc;
    }



    public IActionResult LicenseBacth()
    {

      return View();
    }
        public IActionResult AddLicense()
        {
            return View();
        }

        public IActionResult ViewLicense()
        {

      var lics = _context.Licenses.Include(x => x.BatchLK).ToList();


        
            return View(lics);
        }

        public IActionResult LicenseType()
        {


            return View(_context.LicenseTypes.ToList());
        }


        [HttpPost]
        public async Task<IActionResult> CreateLicenceType([FromBody]LicenseType licenseType)
        {

            if (licenseType != null)
            {
                licenseType.Id = Guid.NewGuid();
               

                try
                {
                    _context.Add(licenseType);
                    await _context.SaveChangesAsync();

                    return Json(new
                    {
                        msg = "Success"
                    });

                }
                catch (Exception ee)
                {
                    return Json(new
                    {
                        msg = "Failed"
                    });

                }

            }

            return Json(new
            {
                msg = "No Data"
            });

        }


        static Random random = new Random();
    public static string GetRandomHexNumber(int digits)
    {
      byte[] buffer = new byte[digits / 2];
      random.NextBytes(buffer);
      string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
      if (digits % 2 == 0)
        return result;
      return result + random.Next(16).ToString("X");
    }

  }
}