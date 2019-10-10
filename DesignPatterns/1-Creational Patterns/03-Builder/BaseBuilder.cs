namespace DesignPatterns.BuilderPattern
{
	/// <summary>
	/// 抽象建造者，这个场景下为 "组装人员" ，这里也可以定义为接口
	/// </summary>
	public abstract class BaseBuilder
	{
		/// <summary>
		/// 电脑主机
		/// </summary>
		protected Computer computer = new Computer();

		/// <summary>
		/// 安装CPU
		/// </summary>
		public abstract void BuildPartCPU();

		/// <summary>
		/// 安装主板
		/// </summary>
		public abstract void BuildPartMainBoard();

		/// <summary>
		/// 安装显卡
		/// </summary>
		public virtual void BuildPartGraphicsCard()
		{
			computer.Add("组件集成显卡安装完毕");
		}

		/// <summary>
		/// 安装声卡
		/// </summary>
		public virtual void BuildPartSoundCard()
		{
			computer.Add("组件集成声卡安装完毕");
		}

		// 当然还有装硬盘，电源等组件，这里省略

		/// <summary>
		/// 获得组装好的电脑
		/// </summary>
		/// <returns>组装好的电脑</returns>
		public abstract Computer GetComputer();
	}
}
