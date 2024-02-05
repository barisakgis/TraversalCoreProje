using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {                  /// program cs de add logging metodu yazdık   _logger hazır vardı zaten
            _logger.LogInformation(" Index sayfası çağrıldı");  // _logger aracılığıyla loglama için yaptık 

            _logger.LogError("Error log çağrıldı ");  
            return View();
        }

        public IActionResult Privacy()
        { 
            DateTime d =Convert.ToDateTime(DateTime.Now.ToLongDateString());  ///  gün ve saat getir  privacy sayfası için 
            _logger.LogInformation(d + " Privacy sayfası çağrıldı");  // _logger aracılığıyla loglama için yaptık  program cs var bazı kodlar
            return View();
        }

        public IActionResult Test()
        {
            _logger.LogInformation(" Test sayfası çağrıldı");  // _logger aracılığıyla loglama için yaptık 

            return View();   ////  bu sayfadan direkt  f5 ile çalıştır ctrf5 ile yapma  home/ındex git output a bak
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}