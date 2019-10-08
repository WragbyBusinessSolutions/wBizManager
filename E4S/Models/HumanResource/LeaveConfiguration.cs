﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E4S.Models.HumanResource
{
  public class LeaveConfiguration : BaseClass
  {
    public Guid Id { get; set; }
    public string LeaveTitle { get; set; }
    public string Description { get; set; }
    public int MaxDuration { get; set; }
    public int MaxApplication { get; set; }
    public bool IsActive { get; set; }
    public string Status { get; set; }
  }
}
