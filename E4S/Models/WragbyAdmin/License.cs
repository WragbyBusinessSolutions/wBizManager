using E4S.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizManager.Models.WragbyAdmin
{
  public class License : BaseClass
  {
    public Guid Id { get; set; }
    public string LicenseKey { get; set; }
    public string UserEmail { get; set; }
    public Guid UserId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Guid BatchLKId { get; set; }
    public virtual BatchLK BatchLK { get; set; }

  }
}
