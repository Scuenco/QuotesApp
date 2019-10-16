using System.ComponentModel.DataAnnotations;

namespace QuotesApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength=6, ErrorMessage="You must specify password between 6 and 8.")]
        public string Password { get; set; }
    }
}