namespace DesignPatterns.FactoryMethodPattern
{
	/// <summary>
	/// 西红柿炒蛋工厂类
	/// </summary>
	public class TomatoScrambledEggsFactory : BaseCreator
	{
		/// <summary>
		/// 负责创建西红柿炒蛋这道菜
		/// </summary>
		/// <returns>西红柿炒蛋这道菜</returns>
		public override BaseFood CreateFoodFactory()
		{
			return new TomatoScrambledEggs();
		}
	}
}
