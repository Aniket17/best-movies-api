using System.ComponentModel.DataAnnotations;

namespace best_movies_api.Controllers
{
    public class LoginCredentials
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}