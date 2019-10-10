namespace DesignPatterns.BridgePattern
{
	/// <summary>
	/// 抽象概念中的遥控器，扮演抽象化角色
	/// 桥接模式即将抽象部分与实现部分脱耦，使它们可以独立变化。
	/// 目的是使抽象化和实现部分两者分离，根据面向对象的封装变化的原则，可以把实现部分的变化封装到另外一个类中
	/// 这样的分离的好处在于，在不影响客户端调用的前提下，当其中一个实现类需要改变时，其变化不会影响到其他实现类
	/// 注意：桥接模式与装饰者模式的区别在于，桥接模式的扩展类<seealso cref="BaseTV"/>没有继承抽象类<seealso cref="BaseRemoteControl"/>的接口
	///		  可以说桥接模式的扩展类可以是与之无关的接口或者抽象。（而装饰模式中的装饰类则派生自抽象类，虽然没有具体实现）
	///		  因此，桥接模式适用于一个类存在两个独立变化的维度，且两个维度都需要进行扩展。
	///		  （即例子中的控制器抽象类<seealso cref="BaseRemoteControl"/>和电视抽象类<seealso cref="BaseTV"/>彼此都可以有自己的扩展）
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
		/// 通过组合方式引用新的接口，此处就是桥梁，该类型相当于Implementor类型
		/// </summary>
		protected BaseTV _implementor;

		/// <summary>
		/// 通过构造器注入，初始化扩展的实现
		/// </summary>
		public BaseRemoteControl(BaseTV baseTV)
		{
			this._implementor = baseTV;
		}

		/// <summary>
		/// 返回操作状态
		/// </summary>
		/// <returns></returns>
		public string GetQueueStatus()
		{
			if(this._implementor != null)
			{
				return this._implementor.QueueStatus;
			}
			return string.Empty;
		}

		/// <summary>
		/// 开电视机，这里抽象类中不再提供实现了，而是调用实现类中的实现
		/// </summary>
		public virtual void On()
		{
			this._implementor.On();
		}

		/// <summary>
		/// 关电视机
		/// </summary>
		public virtual void Off()
		{
			this._implementor.Off();
		}

		/// <summary>
		/// 换频道
		/// </summary>
		public virtual void SetChannel()
		{
			this._implementor.TuneChannel();
		}
	}
}
