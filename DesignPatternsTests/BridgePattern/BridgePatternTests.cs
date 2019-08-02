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
			// 创建一个遥控器
			var control = new ConcreteRemote
			{
				// 长虹电视机
				Implementor = new ChangHongTV()
			};

			control.On();
			Assert.AreEqual("长虹牌电视机已经打开了", control.Implementor.QueueStatus);

			control.Off();
			Assert.AreEqual("长虹牌电视机已经关闭了", control.Implementor.QueueStatus);

			control.SetChannel();
			Assert.AreEqual("延迟2秒 -> 长虹牌电视机换台", control.Implementor.QueueStatus);
		}

		/// <summary>
		/// 三星电视控制器测试
		/// </summary>
		[TestMethod()]
		public void SamsungRemoteControlTest01()
		{
			// 创建一个遥控器
			var control = new ConcreteRemote
			{
				// 三星电视机
				Implementor = new SamsungTV()
			};

			control.On();
			Assert.AreEqual("三星牌电视机已经打开了", control.Implementor.QueueStatus);

			control.Off();
			Assert.AreEqual("三星牌电视机已经关闭了", control.Implementor.QueueStatus);

			control.SetChannel();
			Assert.AreEqual("延迟2秒 -> 三星牌电视机换台(小窗口显示)", control.Implementor.QueueStatus);
		}
	}
}