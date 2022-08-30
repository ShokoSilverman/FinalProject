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

        public HomeController(ILogger<HomeController> logger, IVidDAL vidDAL)
        {
            _logger = logger;
            dal = vidDAL;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About(){
            return View();
        }

        [HttpPost]
        public IActionResult Register(String Username, String Password){
            UserPOCO userNew = new UserPOCO();
            userNew.Username = Username;
            userNew.Password = Password;
            if(dal.UserNameExists(Username)){
                return View("Index");
            }
            dal.AddUser(userNew);
            
            Globals.IsLoggedIn = true;
            Globals.CurrentUser = userNew;
            return Redirect("/LoggedIn/ProfilePage");
        }


        public IActionResult PorkAndBeans(){
            return Redirect("https://www.youtube.com/watch?v=TTG6NDZVqWY");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
