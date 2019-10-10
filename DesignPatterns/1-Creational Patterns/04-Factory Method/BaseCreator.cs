namespace DesignPatterns.FactoryMethodPattern
{
	/// <summary>
	/// 抽象工厂类
	/// </summary>
	/// <remarks>
	/// 简单工厂模式系统难以扩展，一旦添加新产品就不得不修改简单工厂方法，这样就会造成简单工厂的实现逻辑过于复杂
	/// 工厂方法模式可以解决简单工厂模式中存在的问题，符合开放封闭原则（即对扩展开发，对修改封闭）。
	/// 把具体产品的创建推迟到子类中，此时工厂类不再负责所有产品的创建，而只是给出具体工厂必须实现的接口
	/// 优点：
	/// 1.每个具体工厂类只完成单个实例的创建,所以它具有很好的可扩展性
	/// 2.利用多态性来完成系统的扩展，对于抽象工厂类和具体工厂中的代码都不需要做任何改动
	/// （比如肉末茄子这道菜，肉末茄子具体工厂类<seealso cref="MincedMeatEggplantFactory"/>、肉末茄子类<seealso cref="MincedMeatEggplant"/>）
	/// </remarks>
	public abstract class BaseCreator
	{
		/// <summary>
		/// 工厂方法
		/// </summary>
		/// <returns>返回菜的抽象类对象</returns>
		public abstract BaseFood CreateFoodFactory();
	}
}
