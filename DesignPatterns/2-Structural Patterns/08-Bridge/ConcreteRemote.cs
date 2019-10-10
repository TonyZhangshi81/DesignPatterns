namespace DesignPatterns.BridgePattern
{
	/// <summary>
	/// 具体的电视遥控器
	/// </summary>
	public class ConcreteRemote : BaseRemoteControl
	{
		/// <summary>
		/// 构造函数初始化
		/// </summary>
		/// <param name="baseTV"></param>
		public ConcreteRemote(BaseTV baseTV) : base(baseTV)
		{
		}

		/// <summary>
		/// 与抽象控制器的不同
		/// </summary>
		public override void SetChannel()
		{
			base.SetChannel();
			base._implementor.QueueStatus = string.Format("延迟2秒 -> {0}", base._implementor.QueueStatus);
		}
	}
}
