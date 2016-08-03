using System;
using NUnit.Framework;
using NUnitTest.PCL;
namespace NUnitTest.Mac
{
	[TestFixture]
	public class MyClass
	{
		public MyClass()
		{
		}

		[Test]
		public void Test1()
		{
			Assert.IsTrue(true);
		}

		[Test]
		public void Test2()
		{
			var ans = MyPCLClass.Add(1, 1);
			Assert.AreEqual(2, ans);
		}
	}
}

