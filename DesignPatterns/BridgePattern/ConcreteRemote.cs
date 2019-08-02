namespace DesignPatterns.BridgePattern
{
	/// <summary>
	/// 具体的电视遥控器
	/// </summary>
	public class ConcreteRemote : BaseRemoteControl
	{
		/// <summary>
		/// 与抽象控制器的不同
		/// </summary>
		public override void SetChannel()
		{
			base.SetChannel();
			Implementor.QueueStatus = string.Format("延迟2秒 -> {0}", Implementor.QueueStatus);
		}
	}
}
