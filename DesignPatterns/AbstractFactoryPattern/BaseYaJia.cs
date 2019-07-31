namespace DesignPatterns.AbstractFactoryPattern
{
	/// <summary>
	/// 鸭架抽象类，供每个地方的鸭架类继承
	/// </summary>
	public abstract class BaseYaJia
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
