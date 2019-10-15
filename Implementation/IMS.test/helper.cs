using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.test
{
	class helper
	{
		public bool valid_email(string email)
		{
			if (email.Contains("@"))
			{
				return true;

			}
			else
			{
				return false;
			}

		}
		public bool valid_password(string password)
		{
			if (password.Length >= 8)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool valid_phone(string phone)
		{
			if (phone.Length == 10)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool valid_username(string username)
		{
			if (username.Length > 8)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
