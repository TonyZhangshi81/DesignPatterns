using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.AdapterPattern.ObjectModelAdapter.Tests
{
	/// <summary>
	/// 匹配器模式测试类
	/// </summary>
	[TestClass()]
	public class PowerAdapterTests
	{
		/// <summary>
		/// 看看使用2转3适配器的效果如何
		/// </summary>
		[TestMethod()]
		public void RequestTest()
		{
			var adapter = new PowerAdapter();

			Assert.AreEqual("【三眼插座】<- 我是两个孔的插头", adapter.Request());
		}
	}
}