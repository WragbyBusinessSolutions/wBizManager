﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using E4S.Data;
using E4S.Models;
using E4S.Services;
using E4S.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E4S.Controllers
{
  [Authorize]
  public class UsersController : Controller
    {
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IEmailSender _emailSender;

    [TempData]
    public string StatusMessage { get; set; }

    public UsersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IEmailSender emailSender)
    {
      _context = context;
      _userManager = userManager;
      _emailSender = emailSender;

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

      var userList = _context.Users.Where(x => x.OrganisationId == orgId).ToList();
      ViewData["StatusMessage"] = StatusMessage;

      return View(userList);
    }

    public IActionResult EditUser(Guid? id)
    {
      var org = getOrg();

      var user = _context.Users.Where(x => x.Id == id.ToString()).FirstOrDefault();

      return View(user);
    }

    [HttpPost]
    public async Task<IActionResult> EditUser(ApplicationUser model)
    {
      var org = getOrg();


      var user = _context.Users.Where(x => x.Id == model.Id).FirstOrDefault();

      var role = user.UserRole;
      user.FirstName = model.FirstName;
      user.LastName = model.LastName;
      user.PhoneNumber = model.PhoneNumber;
      user.UserRole = model.UserRole;

      var roles = await _userManager.GetRolesAsync(user);

      if (user.Id != null)
      {
        foreach (var roleName in roles)
        {
          await _userManager.RemoveFromRoleAsync(user, roleName);
        }
      }



      try
      {
        _context.Update(user);
        await _context.SaveChangesAsync();

        await _userManager.AddToRoleAsync(user, model.UserRole);



      }
      catch
      {
        return View();
      }




      var employeedetails = _context.EmployeeDetails.Where(x => x.UserId == Guid.Parse(model.Id)).FirstOrDefault();
      employeedetails.FirstName = model.FirstName;
      employeedetails.LastName = model.LastName;
      employeedetails.PhoneNumber = model.PhoneNumber;

      _context.Update(employeedetails);
      _context.SaveChanges();

      StatusMessage = "Editting user is succuessful";

      return RedirectToAction("Index");
    }


    public IActionResult AddUser()
    {
      ViewData["StatusMessage"] = StatusMessage;

      var org = getOrg();

      return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddUser(UsersViewModel newuser)
    {
      var orgId = getOrg();

      var user = new ApplicationUser
      {
        Id = Guid.NewGuid().ToString(),
        UserName = newuser.Email,
        Email = newuser.Email,
        OrganisationId = orgId,
        PhoneNumber = newuser.PhoneNumber,
        UserRole = newuser.UserRole,
        EmployeeName = newuser.Username
        
      };

      var orgdetails = _context.Organisations.Where(x => x.Id == orgId).FirstOrDefault();

      var result = await _userManager.CreateAsync(user);
      if (result.Succeeded)
      {
        await _userManager.AddToRoleAsync(user, user.UserRole);

        var Email = user.Email;
        string Code = await _userManager.GeneratePasswordResetTokenAsync(user);
        var callbackUrl = Url.ResetPasswordCallbackLink(user.Id, Code, Request.Scheme);

        var response = _emailSender.SendGridEmailAsync(user.Email, "Create Password",
           callbackUrl, orgdetails.OrganisationName, user.EmployeeName, "setPassword");

        // var response = _emailSender.GmailSendEmail(user.Email, callbackUrl, user.UserRole);
        StatusMessage = "User created successfully.";


        //if(response == "Success")
        //{
        return RedirectToAction("Index");
        //  }
      }
      else
      {
        StatusMessage = "Error creating a user, User already exists.";

        //Repomse user already exist.
      }




      ViewData["StatusMessage"] = StatusMessage;

      return View(newuser);
    }


    private bool UserExists(Guid id)
    {
      return _context.Deductions.Any(e => e.Id == id);
    }


    [HttpPost]
    public IActionResult DeleteUser([FromBody]string deductionId)
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