using TechProsNG_Backend_Task.Models;

namespace TechProsNG_Backend_Task.Services
{
	public interface IUserService
	{
		Task<ApplicationUser> RegisterUser(RegisterModel model);
		Task<ApplicationUser> LoginUser(LoginModel model);
	}

}
