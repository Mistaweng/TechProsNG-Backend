using Microsoft.AspNetCore.Identity;
using TechProsNG_Backend_Task.Models;
using TechProsNG_Backend_Task.Services;

namespace TechProsNG_Backend_Task.Implementation
{
	public class UserRepository : IUserRepository
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;

		public UserRepository(
			UserManager<ApplicationUser> userManager,
			SignInManager<ApplicationUser> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		public async Task<ApplicationUser> RegisterUser(RegisterModel model)
		{
			var user = new ApplicationUser
			{
				Email = model.Email,
				Password = model.Password,
				ConfirmPassword = model.ConfirmPassword
			};

			var result = await _userManager.CreateAsync(user, model.Password);

			if (result.Succeeded)
			{
				return user;
			}

			return null; // Registration failed
		}

		public async Task<ApplicationUser> LoginUser(LoginModel model)
		{
			var user = await _userManager.FindByNameAsync(model.Email);

			if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
			{
				// User login successful
				return user; 
			}

			return null; // Login failed
		}

	}

}
