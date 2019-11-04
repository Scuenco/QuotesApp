using System.Collections.Generic;

namespace QuotesApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PaswordSalt { get; set; }
        public ICollection<Quote> Quotes { get; set; }
    }
}