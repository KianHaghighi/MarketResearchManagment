using Microsoft.AspNetCore.Mvc;
using MarketResearchManagment.Models; // Adjust this to where your models are located
using MarketResearchManagment.Services; // Adjust this for the CsvDataService location

namespace MarketResearchManagment.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ImportCsv()
        {
            var csvDataService = new CsvDataService();
            //FILL IN PATH
            //var companies = csvDataService.ReadCompaniesFromCsv("");

            // Now you can use the products list, e.g., display it in a view or save it to a database
            //return View(companies);
            return View();
        }
    }
}

