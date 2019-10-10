namespace DesignPatterns.AbstractFactoryPattern
{
	/// <summary>
	/// 上海口味的鸭脖
	/// </summary>
	public class ShangHaiYaBo : BaseYaBo
	{
		/// <summary>
		/// 输出菜名
		/// </summary>
		public override void PutInto()
		{
			Dish = "上海口味的鸭脖";
		}
	}
}
