﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace E4S.Controllers.AccountInventory
{
    public class CustomerStatementController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}