using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.FactoryMethodPattern.Tests
{
	/// <summary>
	/// 工厂方法模式测试类
	/// </summary>
	[TestClass()]
	public class MincedMeatEggplantFactoryTests
	{
		/// <summary>
		/// 看看餐馆能做什么菜
		/// </summary>
		[TestMethod()]
		public void CreateFoodFactoryTest()
		{
			var factory = new MincedMeatEggplantFactory();

			// 负责创建肉末茄子这道菜的工程实例
			var food = factory.CreateFoodFactory();

			// 验证
			Assert.IsNotNull(food);
			Assert.AreEqual(typeof(MincedMeatEggplant), food.GetType());
		}
	}
}