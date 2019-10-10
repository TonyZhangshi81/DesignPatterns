namespace DesignPatterns.BuilderPattern
{
	/// <summary>
	/// 具体创建者，具体的某个人为具体创建者
	/// </summary>
	/// <remarks>
	/// 负责组装标准化的个人电脑
	/// </remarks>
	public class ConcreteBuilderA : BaseBuilder
	{
		/// <summary>
		/// 安装CUP
		/// </summary>
		public override void BuildPartCPU()
		{
			computer.Add("组件CPU安装完毕");
		}

		/// <summary>
		/// 安装主板
		/// </summary>
		public override void BuildPartMainBoard()
		{
			computer.Add("组件主板安装完毕");
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
