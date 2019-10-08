using E4S.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizManager.Models.WragbyAdmin
{
  public class LicenseType : BaseClass
  {
    public Guid Id { get; set; }
    public string LicenseTypeName { get; set; }
    public int NoOfAdmin { get; set; }
    public int NoOfUsers { get; set; }
    public string Status { get; set; }
  }
}
