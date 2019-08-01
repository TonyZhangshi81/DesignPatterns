namespace DesignPatterns.AdapterPattern.ObjectModelAdapter
{
	/// <summary>
	/// 三个孔的插头，也就是适配器模式中的目标(Target)角色
	/// </summary>
	public class ThreeHole
	{
		/// <summary>
		/// 客户端需要的方法
		/// </summary>
		/// <returns></returns>
		public virtual string Request()
		{
			return "【三眼插座】<- ";
		}
	}
}
