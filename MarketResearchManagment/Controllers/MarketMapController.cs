using Microsoft.AspNetCore.Mvc;

namespace MarketResearchManagment.Controllers
{
    public class MarketMapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult AnalyzeMarket(string marketName)
        {
            ViewBag.MarketName = marketName;
            return View();
        }
    }
}


