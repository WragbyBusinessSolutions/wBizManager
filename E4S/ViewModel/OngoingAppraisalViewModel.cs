﻿using E4S.Models.HumanResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E4S.ViewModel
{
  public class OngoingAppraisalViewModel
  {
    public Appraisal Appraisal { get; set; }
    public List<EmployeeAppraisal> EmployeeAppraisalList { get; set; }
    public List<AppraisalAssignedTemplate> AppraisalAssignedTemplates { get; set; }

    public List<Job> Jobs { get; set; }
  }


  public class EmployeeAppraisal
  {
        public string AId { get; set; }
        public EmployeeDetail EmployeeDetail { get; set; }
        public Job Job { get; set; }
        public EmployeeDetail AssignedSupervisor { get; set; }
  }
}
