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
    public class LoggedInController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IVidDAL dal;

        public LoggedInController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult MyPage()
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
