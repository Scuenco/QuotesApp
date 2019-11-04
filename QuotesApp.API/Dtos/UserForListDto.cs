using System.Collections.Generic;
using QuotesApp.API.Models;

namespace QuotesApp.API.Dtos
{
    public class UserForListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Quote { get; set; }
        public ICollection<QuotesForDetailsDto> Quotes { get; set; }
    }
}