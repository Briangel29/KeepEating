<<<<<<< HEAD
﻿using KeepEating.Data;
using KeepEating.Models;
using KeepEating.Models.ViewModels;
using KeepEating.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
=======
﻿using KeepEating.Models;
using Microsoft.AspNetCore.Mvc;
>>>>>>> c3c46588479ba917fe066dd902d6370d0ae73074
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
<<<<<<< HEAD
using System.Security.Claims;
=======
>>>>>>> c3c46588479ba917fe066dd902d6370d0ae73074
using System.Threading.Tasks;

namespace KeepEating.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
<<<<<<< HEAD

        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            IndexViewModel IndexVM = new IndexViewModel()
            {
                MenuItem = await _db.MenuItem.Include(m => m.Category).Include(m => m.SubCategory).ToListAsync(),
                Category = await _db.Category.ToListAsync(),
                Coupon = await _db.Coupon.Where(c => c.IsActive == true).ToListAsync()

            };

            //var claimsIdentity = (ClaimsIdentity)User.Identity;
            //var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            //if (claim != null)
            //{
            //    var cnt = _db.ShoppingCart.Where(u => u.ApplicationUserId == claim.Value).ToList().Count;
            //    HttpContext.Session.SetInt32(SD.ssShoppingCartCount, cnt);
            //}


            return View(IndexVM);
=======
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
>>>>>>> c3c46588479ba917fe066dd902d6370d0ae73074
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
