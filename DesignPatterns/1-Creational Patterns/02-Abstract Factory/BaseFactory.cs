﻿namespace DesignPatterns.AbstractFactoryPattern
{
	/// <summary>
	/// 抽象工厂类，提供创建两个不同地方的鸭架和鸭脖的接口
	/// </summary>
	/// <remarks>
	/// 与工厂方法模式一样都觉有很好的扩展性，不同之处在于抽象工厂模式中工厂类会创建一组产品的实力（工厂方法模式每个具体工厂类只完成单个实例的创建）
	/// 抽象工厂模式将具体产品的创建延迟到具体工厂的子类中，这样将对象的创建封装起来，可以减少客户端与具体产品类之间的依赖，从而使系统耦合度低，这样更有利于后期的维护和扩展
	/// 优点：
	/// 1.具有很好的可扩展性
	/// 2.抽象工厂对于系列产品的变化支持“开放——封闭”原则
	/// 2.利用多态性来完成系统的扩展，对于抽象工厂类和具体工厂中的代码都不需要做任何改动
	/// （比如湖南工厂生产湖南口味的鸭脖鸭架，具体工厂类<seealso cref="HuNanFactory"/>、鸭脖类<seealso cref="HuNanYaBo"/>、鸭架类<seealso cref="HuNanYaJia"/>）
	/// 缺点：
	/// 抽象工厂模式很难支持新种类产品的变化。
	/// 这是因为抽象工厂接口中已经确定了可以被创建的产品集合，如果需要添加新产品，此时就必须去修改抽象工厂的接口，这样就涉及到抽象工厂类的以及所有子类的改变，这样也就违背了“开发——封闭”原则。
	/// 前提：
	/// 1.一个系统不要求依赖产品类实例如何被创建、组合和表达的表达，这点也是所有工厂模式应用的前提。
	/// 2.这个系统有多个系列产品，而系统中只消费其中某一系列产品
	/// 3.系统要求提供一个产品类的库，所有产品以同样的接口出现，客户端不需要依赖具体实现。
	/// </remarks>
	public abstract class BaseFactory
	{
		/// <summary>
		/// 工厂方法
		/// </summary>
		/// <returns>返回鸭脖的抽象类对象</returns>
		public abstract BaseYaBo CreateYaBo();

		/// <summary>
		/// 工厂方法
		/// </summary>
		/// <returns>返回鸭架的抽象类对象</returns>
		public abstract BaseYaJia CreateYaJia();
	}
}
