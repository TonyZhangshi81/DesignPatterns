namespace DesignPatterns.AbstractFactoryPattern
{
	/// <summary>
	/// 南昌工厂负责制作南昌口味的鸭脖和鸭架
	/// </summary>
	public class NanChangFactory : BaseFactory
	{
		/// <summary>
		/// 南昌的鸭脖
		/// </summary>
		/// <returns>鸭脖抽象类的实例</returns>
		public override BaseYaBo CreateYaBo()
		{
			return new NanChangYaBo();
		}

		/// <summary>
		/// 南昌的鸭架
		/// </summary>
		/// <returns>鸭架抽象类的实例</returns>
		public override BaseYaJia CreateYaJia()
		{
			return new NanChangYaJia();
		}
	}
}
