using System;
using System.Collections.Generic;

namespace QuotesApp.API.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Region { get; set; }
        public Customer Customer { get; set; }
        public string Period { get; set; }
        public DateTime QuoteNeededBy { get; set; }
        public string Status { get; set; }
        public ICollection<Material> Materials { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }
}