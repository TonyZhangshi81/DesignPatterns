using DesignPatterns.AbstractFactoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTests.AbstractFactoryPattern
{
	/// <summary>
	/// 工厂方法模式测试类
	/// </summary>
	[TestClass()]
	public class AbstractFactoryPatternTests
	{
		/// <summary>
		/// 南昌工厂生产测试
		/// </summary>
		[TestMethod()]
		public void NanChangFactoryTest01()
		{
			// 初始化工厂实例
			var factory = new NanChangFactory();

			// 制作鸭脖
			var yabo = factory.CreateYaBo();
			yabo.PutInto();

			// 制作鸭架
			var yajia = factory.CreateYaJia();
			yajia.PutInto();

			Assert.AreEqual("南昌口味的鸭脖", yabo.Dish);
			Assert.AreEqual("南昌口味的鸭架", yajia.Dish);
		}

		/// <summary>
		/// 上海工厂生产测试
		/// </summary>
		[TestMethod()]
		public void NanChangFactoryTest02()
		{
			// 初始化工厂实例
			var factory = new ShangHaiFactory();

			// 制作鸭脖
			var yabo = factory.CreateYaBo();
			yabo.PutInto();

			// 制作鸭架
			var yajia = factory.CreateYaJia();
			yajia.PutInto();

			Assert.AreEqual("上海口味的鸭脖", yabo.Dish);
			Assert.AreEqual("上海口味的鸭架", yajia.Dish);
		}

		/// <summary>
		/// 湖南工厂生产测试
		/// </summary>
		[TestMethod()]
		public void NanChangFactoryTest03()
		{
			// 初始化工厂实例
			var factory = new HuNanFactory();

			// 制作鸭脖
			var yabo = factory.CreateYaBo();
			yabo.PutInto();

			// 制作鸭架
			var yajia = factory.CreateYaJia();
			yajia.PutInto();

			Assert.AreEqual("湖南口味的鸭脖", yabo.Dish);
			Assert.AreEqual("湖南口味的鸭架", yajia.Dish);
		}
	}
}
