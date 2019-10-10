namespace DesignPatterns.AbstractFactoryPattern
{
	/// <summary>
	/// 上海口味的鸭架
	/// </summary>
	public class ShangHaiYaJia : BaseYaJia
	{
		/// <summary>
		/// 输出菜名
		/// </summary>
		public override void PutInto()
		{
			Dish = "上海口味的鸭架";
		}
	}
}
