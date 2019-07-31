using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.SimpleFactoryPattern.Tests
{
	/// <summary>
	/// 简单工厂模式测试类
	/// </summary>
	[TestClass()]
	public class FoodSimpleFactoryTests
	{
		/// <summary>
		/// 看看餐馆能做什么菜
		/// </summary>
		[TestMethod()]
		public void CreateFoodTest01()
		{
			// 客户想点一个西红柿炒蛋
			BaseFood food = FoodSimpleFactory.CreateFood("西红柿炒蛋");
			food.PutInto();

			Assert.AreEqual("一份西红柿炒蛋", food.Dish);
		}

		/// <summary>
		/// 看看餐馆能做什么菜
		/// </summary>
		[TestMethod()]
		public void CreateFoodTest02()
		{
			// 客户想点一份土豆肉丝
			BaseFood food = FoodSimpleFactory.CreateFood("土豆肉丝");
			food.PutInto();

			Assert.AreEqual("一份土豆肉丝", food.Dish);
		}

		/// <summary>
		/// 看看餐馆能做什么菜
		/// </summary>
		[TestMethod()]
		public void CreateFoodTest03()
		{
			// 客户想点一份红烧肉
			BaseFood food = FoodSimpleFactory.CreateFood("红烧肉");
			// 大厨堵在路上（无法提供所需要的菜）
			Assert.IsNull(food);
		}
	}
}