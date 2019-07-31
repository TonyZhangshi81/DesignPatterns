using DesignPatterns.FactoryMethodPattern;
using DesignPatterns.FactoryMethodPattern.Ext;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTests.FactoryMethodPattern
{
	/// <summary>
	/// 
	/// </summary>
	[TestClass()]
	public class FactoryMethodPatternTest
	{
		/// <summary>
		/// 看看餐馆能做什么菜
		/// </summary>
		[TestMethod()]
		public void CreateFoodTest01()
		{
			// 初始化做菜的工厂
			var factory = new ShreddedPorkWithPotatoesFactory();
			// 做菜
			var food = factory.CreateFoodFactory();
			// 装菜
			food.PutInto();

			Assert.AreEqual("一份土豆肉丝", food.Dish);
		}

		/// <summary>
		/// 看看餐馆能做什么菜
		/// </summary>
		[TestMethod()]
		public void CreateFoodTest02()
		{
			// 初始化做菜的工厂
			var factory = new MincedMeatEggplantFactory();
			// 做菜
			var food = factory.CreateFoodFactory();
			// 装菜
			food.PutInto();

			Assert.AreEqual("肉末茄子好了", food.Dish);
		}

		/// <summary>
		/// 看看餐馆能做什么菜
		/// </summary>
		[TestMethod()]
		public void CreateFoodTest03()
		{
			// 初始化做菜的工厂
			var factory = new TomatoScrambledEggsFactory();
			// 做菜
			var food = factory.CreateFoodFactory();
			// 装菜
			food.PutInto();

			Assert.AreEqual("一份西红柿炒蛋", food.Dish);
		}
	}
}
