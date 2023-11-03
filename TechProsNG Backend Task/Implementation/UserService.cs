using TechProsNG_Backend_Task.Models;
using TechProsNG_Backend_Task.Services;

namespace TechProsNG_Backend_Task.Implementation
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public Task<ApplicationUser> RegisterUser(RegisterModel model)
		{
			return _userRepository.RegisterUser(model);
		}

		public Task<ApplicationUser> LoginUser(LoginModel model)
		{
			return _userRepository.LoginUser(model);
		}
	}

}
