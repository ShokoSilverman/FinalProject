using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VidGameLibDAL3;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVidDAL dal;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About(){
            return View();
        }

        [HttpPost]
        public IActionResult Register(String Username, String _Password){
            UserPOCO userNew = new UserPOCO();
            userNew.Username = Username;
            // string tempPass = Password;
            userNew.Password = _Password;
            dal.AddUser(userNew);
            return Redirect("/Home/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
