using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.AbstractFactoryPattern.Tests
{
	/// <summary>
	/// 抽象工厂模式测试类
	/// </summary>
	[TestClass()]
	public class ShangHaiFactoryTests
	{
		/// <summary>
		/// 做上海口味的鸭脖
		/// </summary>
		[TestMethod()]
		public void CreateYaBoTest()
		{
			// 上海工厂实例
			var factory = new ShangHaiFactory();
			// 生产上海口味的鸭脖
			var yabo = factory.CreateYaBo();

			// 验证
			Assert.IsNotNull(yabo);
			Assert.AreEqual(typeof(ShangHaiYaBo), yabo.GetType());
		}

		/// <summary>
		/// 做上海口味的鸭架
		/// </summary>
		[TestMethod()]
		public void CreateYaJiaTest()
		{
			// 上海工厂实例
			var factory = new ShangHaiFactory();
			// 生产上海口味的鸭架
			var yajia = factory.CreateYaJia();

			// 验证
			Assert.IsNotNull(yajia);
			Assert.AreEqual(typeof(ShangHaiYaJia), yajia.GetType());
		}
	}
}