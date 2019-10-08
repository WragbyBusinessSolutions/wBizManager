using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizManager.ViewModel.WragbyAdminViewModel
{
  public class LicenseBatchViewModel
  {
    public string BatchName { get; set; }
    public int NoOfLicense { get; set; }
    public string BundleDescription { get; set; }
    public Guid LicenseTypeId { get; set; }
    public float LicensePrice { get; set; }
    public int LicenseDays { get; set; }
    public DateTime ExpirationDate { get; set; }
  }
}
