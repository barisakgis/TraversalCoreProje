using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
	public class UserRegisterViewModel
	{

        [Required(ErrorMessage = "lütfen adınızı giriniz")]
        public string Name { get; set; }

		[Required(ErrorMessage = "lütfen soyadınızı giriniz")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "lütfen kullanıcı adınızı giriniz")]
		public string Username { get; set; }

		[Required(ErrorMessage = "lütfen mail  giriniz")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "lütfen şifre giriniz")]
		public string Password { get; set; }

		[Required(ErrorMessage = "lütfen şifre tekrar giriniz")]
		[Compare("Password",ErrorMessage ="şifreler uyumlu değil")]
		public string ConfirmPassword { get; set; }

	}
}
