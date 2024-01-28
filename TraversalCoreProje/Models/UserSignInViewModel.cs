using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="lütfen kullanıcı adını giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "lütfen Şifrenizi giriniz")]
        public string password { get; set; }
    }
}
