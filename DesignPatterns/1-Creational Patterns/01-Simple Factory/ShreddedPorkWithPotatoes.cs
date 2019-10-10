using System;

namespace DesignPatterns.SimpleFactoryPattern
{
	/// <summary>
	/// 土豆肉丝这道菜
	/// </summary>
	public class ShreddedPorkWithPotatoes : BaseFood
	{
		/// <summary>
		/// 输出菜名
		/// </summary>
		public override void PutInto()
		{
			Dish = "一份土豆肉丝";
		}
	}
}
