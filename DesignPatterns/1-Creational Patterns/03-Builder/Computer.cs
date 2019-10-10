using System.Collections.Generic;

namespace DesignPatterns.BuilderPattern
{
	/// <summary>
	/// 电脑类
	/// </summary>
	sealed public class Computer
	{
		/// <summary>
		/// 返回组装后的电脑
		/// </summary>
		public List<string> Parts { get; } = new List<string>();

		/// <summary>
		/// 将单个组件添加到电脑组件集合中
		/// </summary>
		/// <param name="part">单个组件</param>
		internal void Add(string part)
		{
			Parts.Add(part);
		}
	}
}
