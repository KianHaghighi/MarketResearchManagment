using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace MarketResearchManagment.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Topic { get; set; }
    }
}
