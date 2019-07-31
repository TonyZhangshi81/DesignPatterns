namespace DesignPatterns.AbstractFactoryPattern
{
	/// <summary>
	/// 南昌口味的鸭架
	/// </summary>
	public class NanChangYaJia : BaseYaJia
	{
		/// <summary>
		/// 输出菜名
		/// </summary>
		public override void PutInto()
		{
			Dish = "南昌口味的鸭架";
		}
	}
}
