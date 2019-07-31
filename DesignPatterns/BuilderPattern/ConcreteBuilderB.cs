namespace DesignPatterns.BuilderPattern
{
	/// <summary>
	/// 具体创建者，具体的某个人为具体创建者
	/// </summary>
	/// <remarks>
	/// 负责组装一般的游戏电脑
	/// </remarks>
	public class ConcreteBuilderB : BaseBuilder
	{
		/// <summary>
		/// 安装CUP
		/// </summary>
		public override void BuildPartCPU()
		{
			computer.Add("组件高性能CPU安装完毕");
		}

		/// <summary>
		/// 安装声卡
		/// </summary>
		public override void BuildPartGraphicsCard()
		{
			computer.Add("组件显卡安装完毕");
		}

		/// <summary>
		/// 安装主板
		/// </summary>
		public override void BuildPartMainBoard()
		{
			computer.Add("组件主板安装完毕");
		}

		/// <summary>
		/// 安装声卡
		/// </summary>
		public override void BuildPartSoundCard()
		{
			computer.Add("组件声卡安装完毕");
		}

		/// <summary>
		/// 获得组装好的电脑
		/// </summary>
		/// <returns>组装好的电脑</returns>
		public override Computer GetComputer()
		{
			return computer;
		}
	}
}
