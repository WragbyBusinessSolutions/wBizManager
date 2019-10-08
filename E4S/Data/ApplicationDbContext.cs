﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using E4S.Models;
using E4S.Models.HumanResource;
using E4S.Models.AccountInventory;
using E4S.Models.WragbyAdmin;
using BizManager.Models.WragbyAdmin;

namespace E4S.Data
{
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      // Customize the ASP.NET Identity model and override the defaults if needed.
      // For example, you can rename the ASP.NET Identity table names and more.
      // Add your customizations after calling base.OnModelCreating(builder);
    }
    public DbSet<Organisation> Organisations { get; set; }
    public DbSet<JobTitle> JobTitles { get; set; }
    public DbSet<EmploymentStatus> EmploymentStatuses { get; set; }
    public DbSet<JobCategory> JobCategories { get; set; }
    public DbSet<PayGrade> PayGrades { get; set; }
    public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
    public DbSet<ContactDetail> ContactDetails { get; set; }
    public DbSet<Dependant> Dependants { get; set; }
    public DbSet<EmergencyContact> EmergencyContacts { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Salary> Salaries { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Leave> Leaves { get; set; }
    public DbSet<Vacancy> Vacancies { get; set; }
    public DbSet<LeaveConfiguration> LeaveConfigurations { get; set; }
    public DbSet<OrganisationAsset> OrganisationAssets { get; set; }
    public DbSet<InstitutionQualification> InstitutionQualifications { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<WorkExperience> WorkExperiences { get; set; }
    public DbSet<Deduction> Deductions { get; set; }
    public DbSet<Addition> Additions { get; set; }
    public DbSet<SalaryAddition> SalaryAdditions { get; set; }
    public DbSet<SalaryDeduction> SalaryDeductions { get; set; }
    public DbSet<Payroll> Payrolls { get; set; }
    public DbSet<Appraisal> Appraisals { get; set; }
    public DbSet<AppraisalCategory> AppraisalCategories { get; set; }
    public DbSet<AppraisalKPI> AppraisalKPIs { get; set; }
    public DbSet<AppraisalTemplate> AppraisalTemplates { get; set; }
    //public DbSet<AppraisalAssignedTemplate> AppraisalAssignedTemplates { get; set; }
    public DbSet<AppraisalAssignedTemplate> AppraisalAssignedTemplates { get; set; }
    public DbSet<AppraisalEmployeeResult> AppraisalEmployeeResults { get; set; }
    public DbSet<KPIEmployeeResult> KPIEmployeeResults { get; set; }
    public DbSet<AppraisalTemplateCategory> AppraisalTemplateCategories { get; set; }
    public DbSet<AssignedSubordinate> AssignedSubordinates { get; set; }
    public DbSet<AssignedSupervisor> AssignedSupervisors { get; set; }






    //Account DbSet
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<ProductService> ProductServices { get; set; }
    public DbSet<NewInventory> NewInventories { get; set; }
    public DbSet<StockRecord> StockRecords { get; set; }
    public DbSet<AccountBank> AccountBanks { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<OperatingExpense> OperatingExpenses { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Cashflow> Cashflows { get; set; }
    public DbSet<QuoteRecord> QuoteRecords { get; set; }
    public DbSet<QuoteItem> QuoteItems { get; set; }
    public DbSet<InvoiceRecord> InvoiceRecords { get; set; }
    public DbSet<InvoiceItem> InvoiceItems { get; set; }
    public DbSet<CostOfGood> CostOfGoods { get; set; }
    public DbSet<OtherItem> OtherItems { get; set; }
    public DbSet<InvoiceOtherItem> InvoiceOtherItems { get; set; }



    //Admin DbSet
    public DbSet<TicketTread> TicketTreads { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<License> Licenses { get; set; }
    public DbSet<LicenseType> LicenseTypes { get; set; }
    public DbSet<BatchLK> BatchLKs { get; set; }






  }
}
