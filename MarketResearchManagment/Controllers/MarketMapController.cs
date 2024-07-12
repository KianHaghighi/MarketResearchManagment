using Microsoft.AspNetCore.Mvc;

namespace MarketResearchManagment.Controllers
{
    public class MarketMapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
