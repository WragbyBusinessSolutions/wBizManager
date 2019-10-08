using E4S.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizManager.Models.WragbyAdmin
{
  public class BatchLK : BaseClass
  {
    public Guid Id { get; set; }
    public string BatchName { get; set; }
    public string BatchDescription { get; set; }
    public int NoOfLicense { get; set; }
    public int NoOfDays { get; set; }
    public string Status { get; set; }
    public float Price { get; set; }
    public DateTime BatchExpiryDate { get; set; }

    public Guid LicenseTypeId { get; set; }
    public virtual LicenseType LicenseType { get; set; }
  }
}
