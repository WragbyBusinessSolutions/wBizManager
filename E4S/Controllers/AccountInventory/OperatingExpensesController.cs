using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using E4S.Data;
using E4S.Models;
using E4S.Models.AccountInventory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace E4S.Controllers.AccountInventory
{
  [Authorize]
    public class OperatingExpensesController : Controller
    {
    [TempData]
    public string StatusMessage { get; set; }

    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public OperatingExpensesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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

      ViewData["ExpenseType"] = new SelectList(_context.Expenses.Where(x => x.OrganisationId == orgId), "Id", "ExpenseType");
      return View(_context.OperatingExpenses.Where(x => x.OrganisationId == orgId).ToList());
    }

    public IActionResult ExpenseType()
    {
      var orgId = getOrg();

      return View(_context.Expenses.Where(x => x.OrganisationId == orgId).ToList());

    }

    

    [HttpPost]
    public async Task<IActionResult> AddExpenseType([FromBody]Expense expense)
    {
      var orgId = getOrg();

      if (expense != null)
      {

        expense.Id = Guid.NewGuid();
        expense.OrganisationId = orgId;


        try
        {
          _context.Add(expense);
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

      }

      return Json(new
      {
        msg = "No Data"
      });

    }

        public async Task<IActionResult> EditExpenseType(Guid id)
        {
            var orgId = getOrg();

            if (id == null)
            {
                return NotFound();
            }

            var exptyp = await _context.Expenses.FindAsync(id);
            if (exptyp == null)
            {
                return NotFound();
            }
            return View(exptyp);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditExpenseType(Expense expense)
        {
            if (expense.Id == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expense);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpenseTypeExists(expense.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                StatusMessage = "Customer record updated.";

                return RedirectToAction(nameof(ExpenseType));
            }
            return View(expense);
        }


        private bool ExpenseTypeExists(Guid id)
        {
            return _context.Expenses.Any(e => e.Id == id);
        }

        [HttpPost]
        public IActionResult DeleteExpenseType([FromBody]string expenseId)
        {
            if (expenseId == null)
            {
                return Json(new
                {
                    msg = "No Data"
                }
               );
            }

            try
            {
                var exptype = _context.Expenses.SingleOrDefault(m => m.Id == Guid.Parse(expenseId));
                _context.Expenses.Remove(exptype);
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







        [HttpPost]
    public async Task<IActionResult> AddOperatingExpense([FromBody]OperatingExpense operatingExpense)
    {
      var orgId = getOrg();

      if (operatingExpense != null)
      {

        operatingExpense.Id = Guid.NewGuid();
        operatingExpense.OrganisationId = orgId;

        var expenseType = _context.Expenses.Where(x => x.Id == operatingExpense.ExpenseId).FirstOrDefault().ExpenseType;
        if (expenseType == null)
        {
          expenseType = "Others";
        }


        try
        {
          _context.Add(operatingExpense);
          _context.SaveChanges();

          Cashflow credit = new Cashflow()
          {
            Id = Guid.NewGuid(),
            FlowType = "OE",
            FlowTypeId = operatingExpense.Id,
            DebitCredit = "C",
            FlowDetails = "Operating Expenses - " + expenseType + " " + operatingExpense.Description,
            Amount = operatingExpense.Amount,
            OrganisationId = orgId
          };

          _context.Add(credit);
          await _context.SaveChangesAsync();

          Transaction tCredit = new Transaction()
          {
            Id = Guid.NewGuid(),
            TransactionType = "OE",
            TransactionId = operatingExpense.Id,
            DebitCredit = "C",
            TransactionDetails = "Operating Expenses - " + expenseType + " " + operatingExpense.Description,
            Amount = operatingExpense.Amount,
            OrganisationId = orgId
          };

          _context.Add(tCredit);
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

      }

      return Json(new
      {
        msg = "No Data"
      });

    }


        // Edit the Department

        //[HttpPost]
        //public async Task<IActionResult> EditOperatingExpense([FromBody]OperatingExpense operatingExpense)
        //{
        //    if (operatingExpense == null)
        //    {
        //        return Json(new
        //        {
        //            msg = "No Data"
        //        }
        //       );
        //    }

        //    var orgId = getOrg();



        //    return Json(
        //    new
        //    {
        //        msg = "Fail"
        //    });
        //}

        // Ednf of Edit for Department


        [HttpPost]
        public async Task<IActionResult> EditOperatingExpense([FromBody]OperatingExpense operatingExpense)
        {
            var orgId = getOrg();

            if (operatingExpense != null)
            {

                operatingExpense.Id = Guid.NewGuid();
                operatingExpense.OrganisationId = orgId;

                var expenseType = _context.Expenses.Where(x => x.Id == operatingExpense.ExpenseId).FirstOrDefault().ExpenseType;
                if (expenseType == null)
                {
                    expenseType = "Others";
                }


                try
                {
                    _context.Update(operatingExpense);
                    _context.SaveChanges();

                    Cashflow credit = new Cashflow()
                    {
                        Id = Guid.NewGuid(),
                        FlowType = "OE",
                        FlowTypeId = operatingExpense.Id,
                        DebitCredit = "C",
                        FlowDetails = "Operating Expenses - " + expenseType + " " + operatingExpense.Description,
                        Amount = operatingExpense.Amount,
                        OrganisationId = orgId
                    };

                    _context.Update(credit);
                    await _context.SaveChangesAsync();

                    Transaction tCredit = new Transaction()
                    {
                        Id = Guid.NewGuid(),
                        TransactionType = "OE",
                        TransactionId = operatingExpense.Id,
                        DebitCredit = "C",
                        TransactionDetails = "Operating Expenses - " + expenseType + " " + operatingExpense.Description,
                        Amount = operatingExpense.Amount,
                        OrganisationId = orgId
                    };

                    _context.Update(tCredit);
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

            }

            return Json(new
            {
                msg = "No Data"
            });

        }








        private bool OperatingExpenseExists(Guid id)
        {
            return _context.OperatingExpenses.Any(e => e.Id == id);
        }

        [HttpPost]
        public IActionResult DeleteOperatingExpense([FromBody]string expenseId)
        {
            if (expenseId == null)
            {
                return Json(new
                {
                    msg = "No Data"
                }
               );
            }

            try
            {
                var exptype = _context.OperatingExpenses.SingleOrDefault(m => m.Id == Guid.Parse(expenseId));
                _context.OperatingExpenses.Remove(exptype);
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