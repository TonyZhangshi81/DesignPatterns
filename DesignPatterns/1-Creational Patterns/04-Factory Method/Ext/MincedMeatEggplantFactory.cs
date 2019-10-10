namespace DesignPatterns.FactoryMethodPattern
{
	/// <summary>
	/// 肉末茄子工厂类，负责创建肉末茄子这道菜
	/// </summary>
	public class MincedMeatEggplantFactory : BaseCreator
	{
		/// <summary>
		/// 负责创建肉末茄子这道菜
		/// </summary>
		/// <returns>肉末茄子这道菜</returns>
		public override BaseFood CreateFoodFactory()
		{
			return new MincedMeatEggplant();
		}
	}
}
