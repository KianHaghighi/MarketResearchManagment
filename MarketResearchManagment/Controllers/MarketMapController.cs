using MarketResearchManagment.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


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
        public ActionResult UploadMap()
        {
            return View();
        }

        //creates market maps based off a market name string from user input
        [HttpPost]
        public ActionResult AnalyzeMarket(string marketName)
        {
            ViewBag.MarketName = marketName;
            return View();
        }

        [HttpPost]
        public ActionResult UploadMap(IFormFile fileUpload)
        {
            if (fileUpload != null && fileUpload.Length > 0)
            {
                // Construct the save path
                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/MarketMaps");

                // Ensure the directory exists
                Directory.CreateDirectory(uploadPath);

                // Construct the file path where the file will be saved
                var filePath = Path.Combine(uploadPath, fileUpload.FileName);

                // Save the file
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    fileUpload.CopyTo(fileStream);
                }

                // Redirect to a confirmation page or back to the main map page
                return RedirectToAction("Index"); 
            }

            // Return the same view if no file was selected
            return View();
        }


    }
}


