namespace DesignPatterns.BridgePattern
{
	/// <summary>
	/// 长虹牌电视机，重写基类的抽象方法
	/// 提供具体的实现
	/// </summary>
	public class ChangHongTV : BaseTV
	{
		/// <summary>
		/// 关闭
		/// </summary>
		public override void Off()
		{
			QueueStatus = "长虹牌电视机已经关闭了";
		}

		/// <summary>
		/// 打开
		/// </summary>
		public override void On()
		{
			QueueStatus = "长虹牌电视机已经打开了";
		}

		/// <summary>
		/// 换台
		/// </summary>
		public override void TuneChannel()
		{
			QueueStatus = "长虹牌电视机换台";
		}
	}
}
