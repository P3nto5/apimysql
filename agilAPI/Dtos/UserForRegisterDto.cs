using System.ComponentModel.DataAnnotations;

namespace agilAPI.Dtos
{
    public class UserForRegisterDto
    {[Required]
        public string Username { get; set; }
        
         [Required]
         [StringLength(8,MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 8 characters" )]
        public string Password { get; set; }
    
    }
}