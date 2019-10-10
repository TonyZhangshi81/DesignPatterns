namespace DesignPatterns.AbstractFactoryPattern
{
	/// <summary>
	/// 上海工厂负责制作上海口味的鸭脖和鸭架
	/// </summary>
	public class ShangHaiFactory : BaseFactory
	{
		/// <summary>
		/// 上海的鸭脖
		/// </summary>
		/// <returns>鸭脖抽象类的实例</returns>
		public override BaseYaBo CreateYaBo()
		{
			return new ShangHaiYaBo();
		}

		/// <summary>
		/// 上海的鸭架
		/// </summary>
		/// <returns>鸭架抽象类的实例</returns>
		public override BaseYaJia CreateYaJia()
		{
			return new ShangHaiYaJia();
		}
	}
}
