namespace DesignPatterns.BridgePattern
{
	/// <summary>
	/// 三星牌电视机，重写基类的抽象方法
	/// 提供具体的实现
	/// </summary>
	public class SamsungTV : BaseTV
	{
		/// <summary>
		/// 关闭
		/// </summary>
		public override void Off()
		{
			QueueStatus = "三星牌电视机已经关闭了";
		}

		/// <summary>
		/// 打开
		/// </summary>
		public override void On()
		{
			QueueStatus = "三星牌电视机已经打开了";
		}

		/// <summary>
		/// 换台
		/// </summary>
		public override void TuneChannel()
		{
			QueueStatus = "三星牌电视机换台(小窗口显示)";
		}
	}
}
