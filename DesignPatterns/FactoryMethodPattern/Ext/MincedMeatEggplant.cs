namespace DesignPatterns.FactoryMethodPattern.Ext
{
	/// <summary>
	/// 肉末茄子这道菜
	/// </summary>
	public class MincedMeatEggplant : BaseFood
	{
		/// <summary>
		/// 输出菜名
		/// </summary>
		public override void PutInto()
		{
			Dish = "肉末茄子好了";
		}
	}
}
