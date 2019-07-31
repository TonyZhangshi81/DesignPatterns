using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.BuilderPattern.Tests
{
	/// <summary>
	/// 创建者模式测试类
	/// </summary>
	[TestClass()]
	public class BuilderPatternTests
	{
		/// <summary>
		/// 组装标准化的个人电脑
		/// </summary>
		[TestMethod()]
		public void ConstructTest01()
		{
			// 创建指挥者和构造者
			Director director = new Director();
			BaseBuilder builder = new ConcreteBuilderA();

			// 组装电脑
			director.Construct(builder);
			// 组装完毕
			var computer = builder.GetComputer();

			// 组装清单
			var list = computer.Parts;
			// 验证
			Assert.AreEqual("组件CPU安装完毕", list[0]);
			Assert.AreEqual("组件主板安装完毕", list[1]);
			Assert.AreEqual("组件集成显卡安装完毕", list[2]);
			Assert.AreEqual("组件集成声卡安装完毕", list[3]);
		}

		/// <summary>
		/// 组装一般的游戏电脑
		/// </summary>
		[TestMethod()]
		public void ConstructTest02()
		{
			// 创建指挥者和构造者
			Director director = new Director();
			BaseBuilder builder = new ConcreteBuilderB();

			// 组装电脑
			director.Construct(builder);
			// 组装完毕
			var computer = builder.GetComputer();

			// 组装清单
			var list = computer.Parts;
			// 验证
			Assert.AreEqual("组件高性能CPU安装完毕", list[0]);
			Assert.AreEqual("组件主板安装完毕", list[1]);
			Assert.AreEqual("组件显卡安装完毕", list[2]);
			Assert.AreEqual("组件声卡安装完毕", list[3]);
		}

		/// <summary>
		/// 组装高性能的游戏玩家电脑
		/// </summary>
		[TestMethod()]
		public void ConstructTest03()
		{
			// 创建指挥者和构造者
			Director director = new Director();
			BaseBuilder builder = new ConcreteBuilderC();

			// 组装电脑
			director.Construct(builder);
			// 组装完毕
			var computer = builder.GetComputer();

			// 组装清单
			var list = computer.Parts;
			// 验证
			Assert.AreEqual("组件CPU安装完毕", list[0]);
			Assert.AreEqual("组件主板安装完毕", list[1]);
			Assert.AreEqual("组件高性能显卡安装完毕", list[2]);
			Assert.AreEqual("组件高性能声卡安装完毕", list[3]);
		}
	}
}