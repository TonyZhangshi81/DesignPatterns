using System.Collections.Generic;

namespace DesignPatterns.PrototypePattern
{
	/// <summary>
	/// 颜色管理
	/// </summary>
	public class ColorManager
	{
		/// <summary>
		/// 颜色对象容器（都是允许克隆的）
		/// </summary>
		private Dictionary<string, ColorPrototype> _colors = new Dictionary<string, ColorPrototype>();

		/// <summary>
		/// 索引器
		/// </summary>
		public ColorPrototype this[string key]
		{
			get { return _colors[key]; }
			set { _colors.Add(key, value); }
		}
	}
}
