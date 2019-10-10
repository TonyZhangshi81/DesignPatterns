using System;

namespace DesignPatterns.AdapterPattern.ObjectModelAdapter
{
	/// <summary>
	/// 两个孔的插头，源角色——需要适配的类
	/// </summary>
	public class TwoHole
	{
		/// <summary>
		/// 两个孔插头方法
		/// </summary>
		/// <returns></returns>
		public string SpecificRequest()
		{
			return "我是两个孔的插头";
		}
	}
}
