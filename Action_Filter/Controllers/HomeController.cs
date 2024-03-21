using Action_Filter.ActionFilter;
using Action_Filter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Action_Filter.Controllers
{
    // CustomLogging Action Filter bu controler seviyesinde girilen tüm Actionları,Action Filterli bir biçimde ayarlayacaktır.i
    [CustomLoggingActionFilter]
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
    }
}