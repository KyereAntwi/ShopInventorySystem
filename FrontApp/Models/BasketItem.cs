namespace FrontApp.Models
{
    public class BasketItem
    {
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public decimal AmountPayed { get; set; }
    }
}
