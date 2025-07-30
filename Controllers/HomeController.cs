using Microsoft.AspNetCore.Mvc;
using MvcWeb.Models;
using System.Diagnostics;

namespace BirthdayApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Action để hiển thị trang chính
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //Action để xử lí khi người dùng nhấn nút
        [HttpPost]
        public IActionResult ShowBirthdayCard()
        {
            return PartialView("_BirthdayCard");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
