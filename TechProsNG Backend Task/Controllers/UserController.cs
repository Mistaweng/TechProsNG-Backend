using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechProsNG_Backend_Task.Models;
using TechProsNG_Backend_Task.Services;

namespace TechProsNG_Backend_Task.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpPost("register")]
		public async Task<IActionResult> Register(RegisterModel model)
		{
			var user = await _userService.RegisterUser(model);

			if (user != null)
			{
				return Ok(new { Message = "Registration successful" });
			}

			return BadRequest(new { Message = "Registration failed" });
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login(LoginModel model)
		{
			var user = await _userService.LoginUser(model);

			if (user != null)
			{
				return Ok(new { Message = "Login successful", User = user });
			}

			return BadRequest(new { Message = "Login failed" });
		}


	}

}
