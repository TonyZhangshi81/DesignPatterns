namespace DesignPatterns.BridgePattern
{
	/// <summary>
	/// 抽象概念中的遥控器，扮演抽象化角色
	/// 桥接模式即将抽象部分与实现部分脱耦，使它们可以独立变化。
	/// 目的是使抽象化和实现部分两者分离，根据面向对象的封装变化的原则，可以把实现部分的变化封装到另外一个类中
	/// 这样的分离的好处在于，在不影响客户端调用的前提下，当其中一个实现类需要改变时，其变化不会影响到其他实现类
	/// 例子：三星电视的换台与长宏电视略有不同（带有画中画功能）<seealso cref="SamsungTV"/>
	/// 优点：
	/// 1.把抽象接口与其实现解耦。
	/// 2.抽象和实现可以独立扩展，不会影响到对方。
	/// 3.实现细节对客户透明，对用于隐藏了具体实现细节。
	/// 缺点：
	/// 1.增加了系统的复杂度
	/// 场景：
	/// 1.如果一个系统需要在构件的抽象化角色和具体化角色之间添加更多的灵活性，避免在两个层次之间建立静态的联系。
	/// 2.设计要求实现化角色的任何改变不应当影响客户端，或者实现化角色的改变对客户端是完全透明的。
	/// 3.需要跨越多个平台的图形和窗口系统上。
	/// 4.一个类存在两个独立变化的维度，且两个维度都需要进行扩展。
	/// </summary>
	public abstract class BaseRemoteControl
	{
		/// <summary>
		/// 字段
		/// </summary>
		BaseTV _implementor;

		/// <summary>
		/// 属性
		/// </summary>
		public BaseTV Implementor { get => _implementor; set => _implementor = value; }

		/// <summary>
		/// 开电视机，这里抽象类中不再提供实现了，而是调用实现类中的实现
		/// </summary>
		public virtual void On()
		{
			Implementor.On();
		}

		/// <summary>
		/// 关电视机
		/// </summary>
		public virtual void Off()
		{
			Implementor.Off();
		}

		/// <summary>
		/// 换频道
		/// </summary>
		public virtual void SetChannel()
		{
			Implementor.TuneChannel();
		}
	}
}
