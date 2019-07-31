namespace DesignPatterns.AbstractFactoryPattern
{
	/// <summary>
	/// 南昌口味的鸭脖
	/// </summary>
	public class NanChangYaBo : BaseYaBo
	{
		/// <summary>
		/// 输出菜名
		/// </summary>
		public override void PutInto()
		{
			Dish = "南昌口味的鸭脖";
		}
	}
}
