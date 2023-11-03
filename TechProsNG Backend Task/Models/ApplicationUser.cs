using Microsoft.AspNetCore.Identity;

namespace TechProsNG_Backend_Task.Models
{
	public class ApplicationUser : IdentityUser
	{
		public string UserId { get; set; }
		public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
