using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.FactoryMethodPattern.Tests
{
	/// <summary>
	/// 工厂方法模式测试类
	/// </summary>
	[TestClass()]
	public class TomatoScrambledEggsFactoryTests
	{
		/// <summary>
		/// 看看餐馆能做什么菜
		/// </summary>
		[TestMethod()]
		public void CreateFoodFactoryTest()
		{
			var factory = new TomatoScrambledEggsFactory();

			// 负责创建西红柿炒蛋这道菜的工程实例
			var food = factory.CreateFoodFactory();

			// 验证
			Assert.IsNotNull(food);
			Assert.AreEqual(typeof(TomatoScrambledEggs), food.GetType());
		}
	}
}