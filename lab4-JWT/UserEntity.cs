using System;
using Microsoft.AspNetCore.Identity;

namespace lab4_JWT.Identity
{
	public class UserEntity: IdentityUser<int>
	{
		public UserEntity()
		{
		}
	}
}

