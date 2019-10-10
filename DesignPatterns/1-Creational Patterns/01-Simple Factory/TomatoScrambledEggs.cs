using System;

namespace DesignPatterns.SimpleFactoryPattern
{
	/// <summary>
	/// 西红柿炒鸡蛋这道菜
	/// </summary>
	public class TomatoScrambledEggs : BaseFood
	{
		/// <summary>
		/// 输出菜名
		/// </summary>
		public override void PutInto()
		{
			Dish = "一份西红柿炒蛋";
		}
	}
}
