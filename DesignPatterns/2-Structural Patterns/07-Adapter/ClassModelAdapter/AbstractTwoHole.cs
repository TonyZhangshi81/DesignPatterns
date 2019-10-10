using System;

namespace DesignPatterns.AdapterPattern.ClassModelAdapter
{
	/// <summary>
	/// 两个孔的插头，源角色——需要适配的类
	/// </summary>
	public abstract class AbstractTwoHole
	{
		/// <summary>
		/// 两个孔插头方法
		/// </summary>
		protected virtual string SpecificRequest()
		{
			return "我是两个孔的插头";
		}
	}
}
