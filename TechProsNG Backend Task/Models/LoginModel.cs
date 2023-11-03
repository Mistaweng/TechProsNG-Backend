namespace TechProsNG_Backend_Task.Models
{
	using System.ComponentModel.DataAnnotations;

	public class LoginModel
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}

}
