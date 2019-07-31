namespace DesignPatterns.AbstractFactoryPattern
{
	/// <summary>
	/// 湖南口味的鸭脖
	/// </summary>
	public class HuNanYaBo : BaseYaBo
	{
		/// <summary>
		/// 输出菜名
		/// </summary>
		public override void PutInto()
		{
			Dish = "湖南口味的鸭脖";
		}
	}
}
