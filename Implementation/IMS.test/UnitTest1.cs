using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IMS.test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void valid_email_test()
		{
			helper h = new helper();
			bool b = h.valid_email("test@test.com");
			Assert.AreEqual(true, b);
		}
		[TestMethod]
		public void valid_password_test()
		{
			helper h = new helper();
			bool b = h.valid_password("mahesh12");
			Assert.AreEqual(true, b);
		}

		[TestMethod]
		public void valid_phone_test()
		{
			helper h = new helper();
			bool b = h.valid_phone("9808777777");
			Assert.AreEqual(true, b);

		}
		[TestMethod]
		public void valid_username_test()
		{
			helper h = new helper();
			bool b = h.valid_username("mahesh111");
			Assert.AreEqual(true, b);
		}
	}
}
