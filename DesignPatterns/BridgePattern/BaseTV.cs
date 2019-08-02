namespace DesignPatterns.BridgePattern
{
	/// <summary>
	/// 电视机，提供抽象方法完成基本功能
	/// </summary>
	public abstract class BaseTV
	{
		/// <summary>
		/// 指令状态
		/// </summary>
		public string QueueStatus { get; set; }
		/// <summary>
		/// 打开
		/// </summary>
		public abstract void On();
		/// <summary>
		/// 关闭
		/// </summary>
		public abstract void Off();
		/// <summary>
		/// 换台
		/// </summary>
		public abstract void TuneChannel();
	}
}
