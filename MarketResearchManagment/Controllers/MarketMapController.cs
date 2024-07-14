using MarketResearchManagment.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketResearchManagment.Controllers
{
    public class MarketMapController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/
        public ActionResult Index()
        {
            // Optionally, fetch market map data from a database or service
            var marketMaps = new List<MarketMap>
        {
            new MarketMap { Id = 1, Name = "PropTech Map", Description = "This market map displays and segments the companies in the Real Estate Tech Space", ImageUrl= "/Content/MarketMaps/PropTechMap.png"},
        };

            return View(marketMaps); 
        }

        [HttpPost]
        public ActionResult AnalyzeMarket(string marketName)
        {
            ViewBag.MarketName = marketName;
            return View();
        }
    }
}


