using System.ComponentModel.DataAnnotations;

namespace QuotesApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(13, MinimumLength=4, ErrorMessage="You must specify password between 4 and 13.")]
        public string Password { get; set; }
        
    }
}