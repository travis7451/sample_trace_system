using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using 產品驗證系統.Models;
using System.Data;
using System.Data.SqlClient;
using DBconnTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 產品驗證系統.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult RDtable()
        {
            return View();
        }

        public IActionResult RDinfo()
        {
            return View();
        }

        public IActionResult PMdetail()
        {
            
            return View();
        }
        public IActionResult PMtable()
        {
            return View();
        }

        public IActionResult PMedit()
        {
            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       


    }
}