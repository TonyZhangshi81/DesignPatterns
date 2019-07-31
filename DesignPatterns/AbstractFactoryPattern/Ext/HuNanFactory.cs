namespace DesignPatterns.AbstractFactoryPattern
{
	/// <summary>
	/// 湖南工厂负责制作湖南口味的鸭脖和鸭架
	/// </summary>
	public class HuNanFactory : BaseFactory
	{
		/// <summary>
		/// 湖南的鸭脖
		/// </summary>
		/// <returns>鸭脖抽象类的实例</returns>
		public override BaseYaBo CreateYaBo()
		{
			return new HuNanYaBo();
		}

		/// <summary>
		/// 湖南的鸭架
		/// </summary>
		/// <returns>鸭架抽象类的实例</returns>
		public override BaseYaJia CreateYaJia()
		{
			return new HuNanYaJia();
		}
	}
}
