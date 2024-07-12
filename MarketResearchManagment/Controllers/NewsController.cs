using System.Diagnostics;
using MarketResearchManagment.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketResearchManagment.Controllers
{
    public class NewsController : Controller
    {
        private readonly HackerNewsService _hackerNewsService;

        public NewsController(HackerNewsService hackerNewsService)
        {
            _hackerNewsService = hackerNewsService;
        }

        public async Task<IActionResult> Index()
        {
            // Example: Fetching a specific story by ID
            var story = await _hackerNewsService.GetStoryAsync(8863); // Use an actual story ID
            return View(story);
        }
    }
}