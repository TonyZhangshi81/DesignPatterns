using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.AbstractFactoryPattern.Tests
{
	/// <summary>
	/// 抽象工厂模式测试类
	/// </summary>
	[TestClass()]
	public class NanChangFactoryTests
	{
		/// <summary>
		/// 做南昌口味的鸭脖
		/// </summary>
		[TestMethod()]
		public void CreateYaBoTest()
		{
			// 南昌工厂实例
			var factory = new NanChangFactory();
			// 生产南昌口味的鸭脖
			var yabo = factory.CreateYaBo();

			// 验证
			Assert.IsNotNull(yabo);
			Assert.AreEqual(typeof(NanChangYaBo), yabo.GetType());
		}

		/// <summary>
		/// 做南昌口味的鸭架
		/// </summary>
		[TestMethod()]
		public void CreateYaJiaTest()
		{
			// 南昌工厂实例
			var factory = new NanChangFactory();
			// 生产南昌口味的鸭架
			var yajia = factory.CreateYaJia();

			// 验证
			Assert.IsNotNull(yajia);
			Assert.AreEqual(typeof(NanChangYaJia), yajia.GetType());
		}
	}
}