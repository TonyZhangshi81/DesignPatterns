using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.BridgePattern.Tests
{
	/// <summary>
	/// 桥接模式测试类
	/// </summary>
	[TestClass()]
	public class BridgePatternTests
	{
		/// <summary>
		/// 长虹电视控制器测试
		/// </summary>
		[TestMethod()]
		public void ChangHongRemoteControlTest01()
		{
			// 长虹电视机
			var tv = new ChangHongTV();
			// 创建一个遥控器
			BaseRemoteControl control = new ConcreteRemote(tv);

			control.On();
			Assert.AreEqual("长虹牌电视机已经打开了", control.GetQueueStatus());

			control.Off();
			Assert.AreEqual("长虹牌电视机已经关闭了", control.GetQueueStatus());

			control.SetChannel();
			Assert.AreEqual("延迟2秒 -> 长虹牌电视机换台", control.GetQueueStatus());
		}

		/// <summary>
		/// 三星电视控制器测试
		/// </summary>
		[TestMethod()]
		public void SamsungRemoteControlTest01()
		{
			// 三星电视机
			var tv = new SamsungTV();
			// 创建一个遥控器
			BaseRemoteControl control = new ConcreteRemote(tv);

			control.On();
			Assert.AreEqual("三星牌电视机已经打开了", control.GetQueueStatus());

			control.Off();
			Assert.AreEqual("三星牌电视机已经关闭了", control.GetQueueStatus());

			control.SetChannel();
			Assert.AreEqual("延迟2秒 -> 三星牌电视机换台(小窗口显示)", control.GetQueueStatus());
		}
	}
}