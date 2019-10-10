namespace DesignPatterns.AbstractFactoryPattern
{
	/// <summary>
	/// 湖南口味的鸭架
	/// </summary>
	public class HuNanYaJia : BaseYaJia
	{
		/// <summary>
		/// 输出菜名
		/// </summary>
		public override void PutInto()
		{
			Dish = "湖南口味的鸭架";
		}
	}
}
