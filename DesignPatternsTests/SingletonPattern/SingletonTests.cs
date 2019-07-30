using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.SingletonPattern.Tests
{
	/// <summary>
	/// 单体模式测试类
	/// </summary>
	[TestClass()]
	public class SingletonTests
	{
		/// <summary>
		/// 针对获取对象实例方法GetInstance()的测试
		/// </summary>
		[TestMethod()]
		public void GetInstanceTest()
		{
			Assert.IsNotNull(Singleton.GetInstance());
		}
	}
}