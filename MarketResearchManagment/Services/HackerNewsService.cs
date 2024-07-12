using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

using MarketResearchManagment.Models;

public class HackerNewsService
{
    private readonly HttpClient _httpClient;

    public HackerNewsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<HackerNewsStory> GetStoryAsync(int storyId)
    {
        var storyUrl = $"https://hacker-news.firebaseio.com/v0/item/{storyId}.json";
        var response = await _httpClient.GetStringAsync(storyUrl);
        var story = JsonConvert.DeserializeObject<HackerNewsStory>(response);
        return story;
    }
}
