﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E4S.ViewModel
{
      public class PostNewTicket
      {
            public string AId { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Severity { get; set; }
             public string Status { get; set; }
             public int SupportId { get; set; }
             public string ImageUrl { get; set; }

      }    
}
