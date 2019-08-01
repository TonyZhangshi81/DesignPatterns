namespace DesignPatterns.AdapterPattern.ObjectModelAdapter
{
	/// <summary>
	/// 对象的适配器模式
	/// 适配器模式用来解决现有对象与客户端期待接口不一致的问题
	/// </summary>
	/// <remarks>
	/// 适配器模式——把一个类的接口变换成客户端所期待的另一种接口，从而使原本接口不匹配而无法一起工作的两个类能够在一起工作。
	/// 与类的适配器的区别：
	/// 1.基于目标对象类<seealso cref="ThreeHole"/>
	/// 2.引用现有功能类的对象实例<seealso cref="TwoHole"/>
	/// 3.对于目标对象需要配备的方法进行重写（调用上述功能类的对象实例方法）
	/// 优点：
	/// 1.可以在不修改原有代码的基础上来复用现有类，很好地符合 “开闭原则”
	/// 2.采用“对象组合”的方式，更符合松耦合。（比如Adaptee增加抽象方法，不需要修改现有适配器代码）
	/// 缺点：
	/// 1.使得重定义Adaptee<seealso cref="TwoHole"/>的行为较困难，这就需要生成Adaptee的子类并且使得Adapter引用这个子类而不是引用Adaptee本身。
	/// 场景：
	/// 1.系统需要复用现有类，而该类的接口不符合系统的需求
	/// 2.想要建立一个可重复使用的类，用于与一些彼此之间没有太大关联的一些类，包括一些可能在将来引进的类一起工作。
	/// 3.对于对象适配器模式，在设计里需要改变多个已有子类的接口，如果使用类的适配器模式，就要针对每一个子类做一个适配器，而这不太实际。
	/// </remarks>
	public class PowerAdapter : ThreeHole
	{
		/// <summary>
		/// 引用两个孔插头的实例,从而将客户端与TwoHole联系起来
		/// </summary>
		public TwoHole twoholeAdaptee = new TwoHole();

		/// <summary>
		/// 实现三个孔插头接口方法
		/// </summary>
		/// <remarks>
		/// 因为引用关系，所以不能修改SpecificRequest方法
		/// </remarks>
		/// <returns></returns>
		public override string Request()
		{
			// 调用两个孔插头方法
			return string.Format("【三眼插座】<- {0}", twoholeAdaptee.SpecificRequest());
		}
	}
}
