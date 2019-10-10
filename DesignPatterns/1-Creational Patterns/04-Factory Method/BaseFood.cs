namespace DesignPatterns.FactoryMethodPattern
{
	/// <summary>
	/// 菜抽象类
	/// </summary>
	public abstract class BaseFood
	{
		/// <summary>
		/// 餐具
		/// </summary>
		public string Dish { get; set; }
		/// <summary>
		/// 输出点了什么菜
		/// </summary>
		public abstract void PutInto();
	}
}
