using System;

namespace FrontApp.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime AddedAt { get; set; }
        public decimal UnitCostPrice { get; set; }
        public decimal UnitSellingPrice { get; set; }
        public DateTime AverageExpiration { get; set; }
        public string StockedBy { get; set; }
        public int TotalQuantity { get; set; }
    }
}
