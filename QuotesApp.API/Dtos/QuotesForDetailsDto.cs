using System;
using System.Collections.Generic;
using QuotesApp.API.Models;

namespace QuotesApp.API.Dtos
{
    public class QuotesForDetailsDto
    {
        public int Id { get; set; }
        public string Region { get; set; }
        public string Customer { get; set; }
        public string Period { get; set; }
        public DateTime QuoteNeededBy { get; set; }
        public string Status { get; set; }
        public ICollection<MaterialForQuotesForDetailsDto> Materials { get; set; }
    }
}