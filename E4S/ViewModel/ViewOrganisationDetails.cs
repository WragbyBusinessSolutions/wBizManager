using E4S.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizManager.ViewModel
{
    public class ViewOrganisationDetails
    {    
        public Organisation Organisation { get; set; }
        public List<ApplicationUser> applicationUsers { get; set; }
        
    }
}
