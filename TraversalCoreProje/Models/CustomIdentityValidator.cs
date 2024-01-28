using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProje.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"parola mimimum {length} karakter olmalıdır"

			};
		}
		public override IdentityError PasswordRequiresUpper()
		 
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description =  "parola en az 1 büyük harf olmalıdır "

			};
 
		}
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = "parola en az 1 küçük harf olmalıdır "

			};

		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		 
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "parola en az 1 sembol  içermelidir "

			};

		}


	}
}
