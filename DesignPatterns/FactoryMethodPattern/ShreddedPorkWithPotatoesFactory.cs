namespace DesignPatterns.FactoryMethodPattern
{
	/// <summary>
	/// 土豆肉丝工厂类
	/// </summary>
	public class ShreddedPorkWithPotatoesFactory : BaseCreator
	{
		/// <summary>
		/// 负责创建土豆肉丝这道菜
		/// </summary>
		/// <returns>土豆肉丝这道菜</returns>
		public override BaseFood CreateFoodFactory()
		{
			return new ShreddedPorkWithPotatoes();
		}
	}
}
