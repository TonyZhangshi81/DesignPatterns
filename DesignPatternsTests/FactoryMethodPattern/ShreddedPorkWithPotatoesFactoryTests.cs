using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.FactoryMethodPattern.Tests
{
	/// <summary>
	/// 工厂方法模式测试类
	/// </summary>
	[TestClass()]
	public class ShreddedPorkWithPotatoesFactoryTests
	{
		/// <summary>
		/// 看看餐馆能做什么菜
		/// </summary>
		[TestMethod()]
		public void CreateFoodFactoryTest()
		{
			var factory = new ShreddedPorkWithPotatoesFactory();

			// 负责创建土豆肉丝这道菜的工程实例
			var food = factory.CreateFoodFactory();

			Assert.IsNotNull(food);
		}
	}
}