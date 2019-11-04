namespace QuotesApp.API.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Quote Quote { get; set; }
        public int QuoteId { get; set; }
    }
}