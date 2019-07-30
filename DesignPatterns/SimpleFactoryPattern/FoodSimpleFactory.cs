namespace DesignPatterns.SimpleFactoryPattern
{
	/// <summary>
	/// 简单工厂类, 负责炒菜
	/// </summary>
	/// <remarks>
	/// 原本顾客自己需要做菜，而现在这个做菜的工作交给了餐馆
	/// 此时消费者（也就是我们）对菜（也就是具体对象）的依赖关系从直接变成的间接的，这样就是实现了面向对象的另一个原则——降低对象之间的耦合度
	/// 优点：
	/// 1.简单工厂模式解决了客户端直接依赖于具体对象的问题，客户端可以消除直接创建对象的责任，而仅仅是消费产品。简单工厂模式实现了对责任的分割。
	/// 2.简单工厂模式也起到了代码复用的作用。不同的消费者只需要负责消费，不需要关心其中的实现（所以众口难调，大厨的菜系都是同一个口味）
	/// 缺点：
	/// 1.工厂类集中了所有产品创建逻辑，一旦不能正常工作，整个系统都会受到影响（通俗地意思就是：一旦餐馆没饭或者关门了，很多不愿意做饭的人就没饭吃了）
	/// 2.系统扩展困难，一旦添加新产品就不得不修改工厂逻辑，这样就会造成工厂逻辑过于复杂。
	/// （工厂方法可以很好地解决这些问题）
	/// 场景：
	/// 1.当工厂类负责创建的对象比较少时可以考虑使用简单工厂模式
	/// 2.客户如果只知道传入工厂类的参数，对于如何创建对象的逻辑不关心时可以考虑使用简单工厂模式
	/// </remarks>
	public class FoodSimpleFactory
	{
		/// <summary>
		/// 做菜
		/// </summary>
		/// <param name="type">顾客点的菜名</param>
		/// <returns>做出顾客所点的菜</returns>
		public static BaseFood CreateFood(string type)
		{
			BaseFood food = null;
			if (type.Equals("土豆肉丝"))
			{
				food = new ShreddedPorkWithPotatoes();
			}
			else if (type.Equals("西红柿炒蛋"))
			{
				food = new TomatoScrambledEggs();
			}

			return food;
		}
	}
}
