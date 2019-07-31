using System;

namespace DesignPatterns.PrototypePattern
{
	/// <summary>
	/// 创建颜色的具体原型
	/// </summary>
	[Serializable]
	public class Color : ColorPrototype
	{
		private readonly int _red;
		private readonly int _green;
		private readonly int _blue;

		/// <summary>
		/// 红绿蓝带参构造函数
		/// </summary>
		public Color(int red, int green, int blue)
		{
			_red = red;
			_green = green;
			_blue = blue;
		}

		/// <summary>
		/// 浅拷贝
		/// </summary>
		/// <returns>返回拷贝后对象</returns>
		public override ColorPrototype Clone()
		{
			// 调用MemberwiseClone方法实现的是浅拷贝，另外还有深拷贝
			return MemberwiseClone() as ColorPrototype;
		}
	}
}
