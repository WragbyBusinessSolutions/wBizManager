﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using E4S.Data;
using E4S.Models;
using E4S.Models.HumanResource;
using E4S.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E4S.Controllers.HumanResource
{
  [Authorize]
  public class JobsController : Controller
  {
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

   

    public JobsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
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
      return View();
    }

    public IActionResult JobTitle()
    {
      var orgId = getOrg();
      var jobTitles = _context.JobTitles.Where(x => x.OrganisationId == orgId).ToList();

            return View(jobTitles);
    }

    [HttpPost]
    public async Task<IActionResult> PostNewJobTitle([FromBody]PostNewJobTitle postNewJobTitle)
    {
      if (postNewJobTitle == null)
      {
        return Json(new
        {
          msg = "No Data"
        }
       );
      }

      var orgId = getOrg();
      var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();
      int noOfEmployee = _context.Users.Where(x => x.OrganisationId == orgId).Count();

      try
      {
        JobTitle newJobTitle = new JobTitle()
        {
          Id = Guid.NewGuid(),
          JobTitleName = postNewJobTitle.JobTitle,
          Description = postNewJobTitle.Description,
          Note = postNewJobTitle.Note,
          OrganisationId = orgId
        };

        _context.Add(newJobTitle);
        _context.SaveChanges();


        return Json(new
        {
          msg = "Success"
        }
     );
      }
      catch (Exception ee)
      {

      }

      return Json(
      new
      {
        msg = "Fail"
      });
    }

        // Edit the Job Title

        [HttpPost]
        public async Task<IActionResult> editJobTitle([FromBody]PostNewJobTitle postNewJobTitle)
        {
            if (postNewJobTitle == null)
            {
                return Json(new
                {
                    msg = "No Data"
                }
               );
            }

            var orgId = getOrg();
            var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();


            //bool isAssign = true;

            //if (postNewDepartment. == Guid.Empty)
            //{
            //    isAssign = false;
            //}

            try
            {

                var orgJobTitle = _context.JobTitles.Where(x => x.Id == Guid.Parse(postNewJobTitle.AId)).FirstOrDefault();
                orgJobTitle.JobTitleName = postNewJobTitle.JobTitle;
                
                _context.Update(orgJobTitle);
                _context.SaveChanges();
                

                return Json(new
                {
                    msg = "Success"
                }
             );
            }
            catch (Exception ee)
            {

            }

            return Json(
            new
            {
                msg = "Fail"
            });
        }



    // Ednf of Edit for Job Title

    
    private bool JobTitleExists(Guid id)
    {
      return _context.Departments.Any(e => e.Id == id);
    }


    [HttpPost]
    public IActionResult DeleteJobTitle([FromBody]string jobId)
    {
      if (jobId == null)
      {
        return Json(new
        {
          msg = "No Data"
        }
       );
      }

      try
      {
        var jobTitle = _context.JobTitles.SingleOrDefault(m => m.Id == Guid.Parse(jobId));
        _context.JobTitles.Remove(jobTitle);
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




    public IActionResult EmploymentStatus()
    {
      var orgId = getOrg();
      var employmentStatuses = _context.EmploymentStatuses.Where(x => x.OrganisationId == orgId).ToList();

      return View(employmentStatuses);
    }

    [HttpPost]
    public async Task<IActionResult> PostNewEmploymentStatus([FromBody]PostNewEmploymentStatus postNewEmploymentStatus)
    {
      if (postNewEmploymentStatus == null)
      {
        return Json(new
        {
          msg = "No Data"
        }
       );
      }

      var orgId = getOrg();
      var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();
      int noOfEmployee = _context.Users.Where(x => x.OrganisationId == orgId).Count();

      try
      {
        EmploymentStatus newEmploymentStatus = new EmploymentStatus()
        {
          Id = Guid.NewGuid(),
          EmploymentStatusName = postNewEmploymentStatus.EmploymentStatusName,
          Description = postNewEmploymentStatus.Description,
          OrganisationId = orgId
        };

        _context.Add(newEmploymentStatus);
        _context.SaveChanges();


        return Json(new
        {
          msg = "Success"
        }
     );
      }
      catch (Exception ee)
      {

      }

      return Json(
      new
      {
        msg = "Fail"
      });
    }


        // Edit the Department

        [HttpPost]
        public async Task<IActionResult> editEmploymentStatus([FromBody]PostNewEmploymentStatus postNewEmploymentStatus)
        {
            if (postNewEmploymentStatus == null)
            {
                return Json(new
                {
                    msg = "No Data"
                }
               );
            }

            var orgId = getOrg();
            var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();

            try
            {

                var orgEmployType = _context.EmploymentStatuses.Where(x => x.Id == Guid.Parse(postNewEmploymentStatus.AId)).FirstOrDefault();
                orgEmployType.EmploymentStatusName = postNewEmploymentStatus.EmploymentStatusName;
                orgEmployType.Description = postNewEmploymentStatus.Description;


                _context.Update(orgEmployType);
                _context.SaveChanges();


                return Json(new
                {
                    msg = "Success"
                }
             );
            }
            catch (Exception ee)
            {

            }

            return Json(
            new
            {
                msg = "Fail"
            });
        }

    // Ednf of Edit for Department

    // Delete of Edit for Category

    private bool EmploymentStatusExists(Guid id)
    {
      return _context.EmploymentStatuses.Any(e => e.Id == id);
    }


    [HttpPost]
    public IActionResult DeleteEmploymentStatus([FromBody]string statusId)
    {
      if (statusId == null)
      {
        return Json(new
        {
          msg = "No Data"
        }
       );
      }

      try
      {
        var status = _context.EmploymentStatuses.SingleOrDefault(m => m.Id == Guid.Parse(statusId));
        _context.EmploymentStatuses.Remove(status);
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

    // end of Delete for employment status


    public IActionResult JobCategory()
    {
      var orgId = getOrg();
      var jobCategory = _context.JobCategories.Where(x => x.OrganisationId == orgId).ToList();

      return View(jobCategory);
    }

    [HttpPost]
    public async Task<IActionResult> NewJobCategory([FromBody]PostNewJobCategory postNewJobCategory)
    {
      if (postNewJobCategory == null)
      {
        return Json(new
        {
          msg = "No Data"
        }
       );
      }

      var orgId = getOrg();
      var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();
      int noOfEmployee = _context.Users.Where(x => x.OrganisationId == orgId).Count();

      try
      {
        JobCategory newJobCategory = new JobCategory()
        {
          Id = Guid.NewGuid(),
          JobCategoryName = postNewJobCategory.JobCategory,
          Description = postNewJobCategory.Description,
          OrganisationId = orgId
        };

        _context.Add(newJobCategory);
        _context.SaveChanges();


        return Json(new
        {
          msg = "Success"
        }
     );
      }
      catch (Exception ee)
      {

      }

      return Json(
      new
      {
        msg = "Fail"
      });
    }


        // Edit the Job Category

        [HttpPost]
        public async Task<IActionResult> editJobCategory([FromBody]PostNewJobCategory postNewJobCategory)
        {
            if (postNewJobCategory == null)
            {
                return Json(new
                {
                    msg = "No Data"
                }
               );
            }

            var orgId = getOrg();
            var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();

            try
            {

                var orgJobCat = _context.JobCategories.Where(x => x.Id == Guid.Parse(postNewJobCategory.AId)).FirstOrDefault();
                orgJobCat.JobCategoryName = postNewJobCategory.JobCategory;
                orgJobCat.Description = postNewJobCategory.Description;


                _context.Update(orgJobCat);
                _context.SaveChanges();


                return Json(new
                {
                    msg = "Success"
                }
             );
            }
            catch (Exception ee)
            {

            }

            return Json(
            new
            {
                msg = "Fail"
            });
        }

        // Ednf of Edit for Category


        // Delete of Edit for Category

        private bool JobCategoriesExists(Guid id)
        {
            return _context.JobCategories.Any(e => e.Id == id);
        }


        [HttpPost]
        public IActionResult deleteJobCategory([FromBody]string jobCatId)
        {
            if (jobCatId == null)
            {
                return Json(new
                {
                    msg = "No Data"
                }
               );
            }

            try
            {
                var JobCategories = _context.JobCategories.SingleOrDefault(m => m.Id == Guid.Parse(jobCatId));
                _context.JobCategories.Remove(JobCategories);
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

        // Delete of Edit for Category



        public IActionResult PayGrade()
        {
            var orgId = getOrg();
            var payGrades = _context.PayGrades.Where(x => x.OrganisationId == orgId).ToList();

            return View(payGrades);
        }

    [HttpPost]
    public async Task<IActionResult> PostNewPayGrade([FromBody]PostNewPayGrade postNewPayGrade)
    {
      if (postNewPayGrade == null)
      {
        return Json(new
        {
          msg = "No Data"
        }
       );
      }

      var orgId = getOrg();
      var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();
      int noOfEmployee = _context.Users.Where(x => x.OrganisationId == orgId).Count();

      try
      {
        PayGrade newPayGrade = new PayGrade()
        {
          Id = Guid.NewGuid(),
          PayGradeName = postNewPayGrade.PayGradeName,
          Currency = postNewPayGrade.Currency,
          MinimumSalary = postNewPayGrade.MinimumSalary,
          MaximumSalary = postNewPayGrade.MaximumSalary,
          OrganisationId = orgId
        };

        _context.Add(newPayGrade);
        _context.SaveChanges();


        return Json(new
        {
          msg = "Success"
        }
     );
      }
      catch (Exception ee)
      {

      }

      return Json(
      new
      {
        msg = "Fail"
      });
    }

    public IActionResult Department()
    {
      var orgId = getOrg();
      var department = _context.Departments.Where(x => x.OrganisationId == orgId).ToList();

      return View(department);
    }

    [HttpPost]
    public async Task<IActionResult> Department([FromBody]PostNewDepartment postNewDepartment)
    {
      if (postNewDepartment == null)
      {
        return Json(new
        {
          msg = "No Data"
        }
       );
      }

      var orgId = getOrg();
      var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();
      int noOfEmployee = _context.Users.Where(x => x.OrganisationId == orgId).Count();

      try
      {
        Department newDepartment = new Department()
        {
          Id = Guid.NewGuid(),
          DepartmentName = postNewDepartment.DepartmentName,
          Description = postNewDepartment.Description,
          OrganisationId = orgId
        };

        _context.Add(newDepartment);
        _context.SaveChanges();


        return Json(new
        {
          msg = "Success"
        }
     );
      }
      catch (Exception ee)
      {

      }

      return Json(
      new
      {
        msg = "Fail"
      });
    }


        // Edit the Department
        [HttpPost]
        public async Task<IActionResult> editDepartment([FromBody]PostNewDepartment postNewDepartment)
        {
            if (postNewDepartment == null)
            {
                return Json(new
                {
                    msg = "No Data"
                }
               );
            }

            var orgId = getOrg();
            var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();
            

            try
            {

                var orgDept = _context.Departments.Where(x => x.Id == Guid.Parse(postNewDepartment.AId)).FirstOrDefault();
                orgDept.DepartmentName = postNewDepartment.DepartmentName;
                orgDept.Description = postNewDepartment.Description;
               

                _context.Update(orgDept);
                _context.SaveChanges();


                return Json(new
                {
                    msg = "Success"
                }
             );
            }
            catch (Exception ee)
            {

            }

            return Json(
            new
            {
                msg = "Fail"
            });
        }

    // Ednf of Edit for Department
    private bool DepartmentExists(Guid id)
    {
      return _context.Departments.Any(e => e.Id == id);
    }


    [HttpPost]
    public IActionResult DeleteDepartment([FromBody]string deptId)
    {
      if (deptId == null)
      {
        return Json(new
        {
          msg = "No Data"
        }
       );
      }

      try
      {
        var department =  _context.Departments.SingleOrDefault(m => m.Id == Guid.Parse(deptId));
        _context.Departments.Remove(department);
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



    public IActionResult LeaveConfiguration()
    {
      var orgId = getOrg();
      var LeaveConfiguration = _context.LeaveConfigurations.Where(x => x.OrganisationId == orgId).ToList();

      return View(LeaveConfiguration);
    }

  
  [HttpPost]
  public async Task<IActionResult> LeaveConfiguration([FromBody]PostNewLeaveConfiguration postNewLeaveConfiguration)
  {
    if (postNewLeaveConfiguration == null)
    {
      return Json(new
      {
        msg = "No Data"
      }
     );
    }

    var orgId = getOrg();
    var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();
    int noOfEmployee = _context.Users.Where(x => x.OrganisationId == orgId).Count();

    try
    {
      LeaveConfiguration newLeaveConfiguration = new LeaveConfiguration()
      {
        Id = Guid.NewGuid(),
        LeaveTitle = postNewLeaveConfiguration.LeaveTitle,
        Description = postNewLeaveConfiguration.Description,
        MaxDuration = postNewLeaveConfiguration.MaxDuration,
        MaxApplication = postNewLeaveConfiguration.MaxApplication,
        OrganisationId = orgId
      };

      _context.Add(newLeaveConfiguration);
      _context.SaveChanges();


      return Json(new
      {
        msg = "Success"
      }
   );
    }
    catch (Exception ee)
    {

    }

    return Json(
    new
    {
      msg = "Fail"
    });
  }
        // Edit the LeaveConfiguration

        [HttpPost]
        public async Task<IActionResult> editLeaveConfiguration([FromBody]PostNewLeaveConfiguration postNewLeaveConfiguration)
        {
            if (postNewLeaveConfiguration == null)
            {
                return Json(new
                {
                    msg = "No Data"
                }
               );
            }

            var orgId = getOrg();
            var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();

            try
            {

                var orgLeaveCon = _context.LeaveConfigurations.Where(x => x.Id == Guid.Parse(postNewLeaveConfiguration.AId)).FirstOrDefault();
                orgLeaveCon.LeaveTitle = postNewLeaveConfiguration.LeaveTitle;
                orgLeaveCon.MaxDuration = postNewLeaveConfiguration.MaxDuration;
                orgLeaveCon.Description = postNewLeaveConfiguration.Description;


                _context.Update(orgLeaveCon);
                _context.SaveChanges();


                return Json(new
                {
                    msg = "Success"
                }
             );
            }
            catch (Exception ee)
            {

            }

            return Json(
            new
            {
                msg = "Fail"
            });
        }

    // Ednf of Edit for Leave Configuration

      //Delete for leave configuration


    private bool LeaveConfigurationExists(Guid id)
    {
      return _context.LeaveConfigurations.Any(e => e.Id == id);
    }


    [HttpPost]
    public IActionResult DeleteLeaveConfiguration([FromBody]string leaveId)
    {
      if (leaveId == null)
      {
        return Json(new
        {
          msg = "No Data"
        }
       );
      }

      try
      {
        var leaveTitle = _context.LeaveConfigurations.SingleOrDefault(m => m.Id == Guid.Parse(leaveId));
        _context.LeaveConfigurations.Remove(leaveTitle);
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



    public IActionResult PayrollConfiguration()
        {
           
            var orgId = getOrg();
            var Add = _context.Additions.Where(x => x.OrganisationId == orgId).ToList();
            var Ded = _context.Deductions.Where(x => x.OrganisationId == orgId).ToList();

            var vm = new AdditionDeductionViewModel
            {
                Additions = Add,
                Deductions = Ded
            };

            return View(vm);
        }

        public IActionResult AddAddition()
        {
            var orgId = getOrg();
            var SalaryAdd = _context.Additions.Where(x => x.OrganisationId == orgId).ToList();

            return View(SalaryAdd);

        }


        [HttpPost]
        public async Task<IActionResult> AddAddition([FromBody]PostNewAddition postNewAddition)
        {
          if (postNewAddition == null)
          {
            return Json(new
            {
              msg = "No Data"
            }
           );
          }

          var orgId = getOrg();

          try
          {
            Addition newAddition = new Addition()
            {
              Id = Guid.NewGuid(),
              AdditionType = postNewAddition.AdditionType,
              Description = postNewAddition.Description,
              OrganisationId = orgId
            };

            _context.Add(newAddition);
            _context.SaveChanges();


            return Json(new
            {
              msg = "Success"
            }
         );
          }
          catch (Exception ee)
          {

          }

          return Json(
          new
          {
            msg = "Fail"
          });
        }


    [HttpPost]
    public async Task<IActionResult> editAdditionType([FromBody]PostNewAddition postNewAddition)
    {
      if (postNewAddition == null)
      {
        return Json(new
        {
          msg = "No Data"
        }
       );
      }

      var orgId = getOrg();
      var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();


      //bool isAssign = true;

      //if (postNewDepartment. == Guid.Empty)
      //{
      //    isAssign = false;
      //}

      try
      {

        var AddType = _context.Additions.Where(x => x.Id == Guid.Parse(postNewAddition.AId)).FirstOrDefault();
        AddType.AdditionType = postNewAddition.AdditionType;
        AddType.Description = postNewAddition.Description;


        _context.Update(AddType);
        _context.SaveChanges();


        return Json(new
        {
          msg = "Success"
        }
     );
      }
      catch (Exception ee)
      {

      }

      return Json(
      new
      {
        msg = "Fail"
      });
    }


    private bool AdditionTypeExists(Guid id)
    {
      return _context.Additions.Any(e => e.Id == id);
    }


    [HttpPost]
    public IActionResult DeleteAdditionType([FromBody]string additionId)
    {
      if (additionId == null)
      {
        return Json(new
        {
          msg = "No Data"
        }
       );
      }

      try
      {
        var additionType = _context.Additions.SingleOrDefault(m => m.Id == Guid.Parse(additionId));
        _context.Additions.Remove(additionType);
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




    // Deduction 

    public IActionResult AddDeduction()
    {
        var orgId = getOrg();
        var SalaryDeduct = _context.Deductions.Where(x => x.OrganisationId == orgId).ToList();

        return View(SalaryDeduct);

    }



    //

    [HttpPost]
    public async Task<IActionResult> AddDeduction([FromBody]PostNewDeduction postNewDeduction)
    {
      if (postNewDeduction == null)
      {
        return Json(new
        {
          msg = "No Data"
        }
       );
      }

      var orgId = getOrg();
      var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();
      int noOfEmployee = _context.Users.Where(x => x.OrganisationId == orgId).Count();

      try
      {
        Deduction newDeduction = new Deduction()
        {
          Id = Guid.NewGuid(),
          DeductionType = postNewDeduction.DeductionType,
          Description = postNewDeduction.Description,
          OrganisationId = orgId
        };

        _context.Add(newDeduction);
        _context.SaveChanges();


        return Json(new
        {
          msg = "Success"
        }
     );
      }
      catch (Exception ee)
      {

      }

      return Json(
      new
      {
        msg = "Fail"
      });
    }


    [HttpPost]
    public async Task<IActionResult> editDeductionType([FromBody]PostNewDeduction postNewDeduction)
    {
      if (postNewDeduction == null)
      {
        return Json(new
        {
          msg = "No Data"
        }
       );
      }

      var orgId = getOrg();
      var organisationDetails = await _context.Organisations.Where(x => x.Id == orgId).FirstOrDefaultAsync();


      //bool isAssign = true;

      //if (postNewDepartment. == Guid.Empty)
      //{
      //    isAssign = false;
      //}

      try
      {

        var DedType = _context.Deductions.Where(x => x.Id == Guid.Parse(postNewDeduction.FId)).FirstOrDefault();
        DedType.DeductionType = postNewDeduction.DeductionType;
        DedType.Description = postNewDeduction.Description;


        _context.Update(DedType);
        _context.SaveChanges();


        return Json(new
        {
          msg = "Success"
        }
     );
      }
      catch (Exception ee)
      {

      }

      return Json(
      new
      {
        msg = "Fail"
      });
    }

    private bool DeductionTypeExists(Guid id)
    {
      return _context.Deductions.Any(e => e.Id == id);
    }


    [HttpPost]
    public IActionResult DeleteDeductionType([FromBody]string deductionId)
    {
      if (deductionId == null)
      {
        return Json(new
        {
          msg = "No Data"
        }
       );
      }

      try
      {
        var deductionType = _context.Deductions.SingleOrDefault(m => m.Id == Guid.Parse(deductionId));
        _context.Deductions.Remove(deductionType);
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
