using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.PrototypePattern.Tests
{
	/// <summary>
	/// 原型模式测试类
	/// </summary>
	[TestClass()]
	public class PrototypePatternTests
	{
		/// <summary>
		/// 对象克隆测试
		/// </summary>
		[TestMethod()]
		public void PrototypeCloneTest01()
		{
			ColorManager colormanager = new ColorManager();

			// 初期化设定
			colormanager["red"] = new Color(255, 0, 0);
			colormanager["green"] = new Color(0, 255, 0);
			colormanager["blue"] = new Color(0, 0, 255);

			// 同样是初期化设定，但对象的内部设定是对外隐藏的
			ColorPrototype prototype = new Color();

			ColorPrototype color1 = colormanager["red"].Clone() as Color;
			Assert.AreEqual(255, color1.Red);
			Assert.AreEqual(0, color1.Green);
			Assert.AreEqual(0, color1.Blue);

			ColorPrototype color2 = prototype as Color;
			Assert.AreEqual(255, color2.Red);
			Assert.AreEqual(255, color2.Green);
			Assert.AreEqual(255, color2.Blue);
		}
	}
}