using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Week2.Models;

namespace Week2.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
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
        public string Name()
        {
            return "Yatish Patel";
        }


        public string Email()
        {
            return "C0827426@mylabton.ca";
        }
        public string Secondary_Email()
        {
            return "xyzlmno9807.gmail.com";
        }

        public IActionResult HtmlTester()
        {
            return View();
        }
    }
}