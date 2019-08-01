namespace DesignPatterns.AdapterPattern.ClassModelAdapter
{
	/// <summary>
	/// 类的适配器模式
	/// 适配器模式用来解决现有对象与客户端期待接口不一致的问题
	/// </summary>
	/// <remarks>
	/// 适配器模式——把一个类的接口变换成客户端所期待的另一种接口，从而使原本接口不匹配而无法一起工作的两个类能够在一起工作。
	/// 与对象适配器的区别：
	/// 1.基于目标接口<seealso cref="IThreeHole"/>
	/// 2.实现这些接口，通过对现有功能类的继承，将其具体实现放入到这些接口中
	/// 优点：
	/// 1.可以在不修改原有代码的基础上来复用现有类，很好地符合“开闭原则”
	/// 2.可以重新定义Adaptee(被适配的类<seealso cref="AbstractTwoHole"/>)的部分行为，因为在类适配器模式中，Adapter是Adaptee的子类
	/// 3.仅仅引入一个对象，并不需要额外的字段来引用Adaptee实例（这个即是优点也是缺点）。
	/// 缺点：
	/// 1.用一个具体的Adapter类对Adaptee和Target进行匹配，当如果想要匹配一个类以及所有它的子类时，类的适配器模式就不能胜任了。因为类的适配器模式中没有引入Adaptee的实例，光调用this.SpecificRequest方法并不能去调用它对应子类的SpecificRequest方法。
	/// 2.采用了“多继承”的实现方式，带来了不良的高耦合。（比如Adaptee增加抽象方法，需要修改现有适配器代码）
	/// 场景：
	/// 1.系统需要复用现有类，而该类的接口不符合系统的需求
	/// 2.想要建立一个可重复使用的类，用于与一些彼此之间没有太大关联的一些类，包括一些可能在将来引进的类一起工作。
	/// 3.对于对象适配器模式，在设计里需要改变多个已有子类的接口，如果使用类的适配器模式，就要针对每一个子类做一个适配器，而这不太实际。
	/// </remarks>
	public class PowerAdapter : AbstractTwoHole, IThreeHole
	{
		/// <summary>
		/// 实现三个孔插头接口方法
		/// </summary>
		/// <returns></returns>
		public string Request()
		{
			// 调用两个孔插头方法
			return string.Format("【三眼插座】<- {0}", SpecificRequest());
		}

		/// <summary>
		/// 适配器能够在现有功能中添加新的功能
		/// </summary>
		/// <returns></returns>
		protected override string SpecificRequest()
		{
			return string.Format("{0}(使用适配器转接2转3)", base.SpecificRequest());
		}
	}
}
