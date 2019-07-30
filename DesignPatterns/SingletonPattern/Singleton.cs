namespace DesignPatterns.SingletonPattern
{
	/// <summary>
	/// 单例模式的实现
	/// </summary>
	/// <remarks>
	/// 场景：某个对象只需要一个实例的情况
	/// </remarks>
	public class Singleton
	{
		/// <summary>
		/// 定义一个静态变量来保存类的实例
		/// </summary>
		private static Singleton uniqueInstance;

		/// <summary>
		/// 定义一个标识确保线程同步
		/// </summary>
		private static readonly object locker = new object();

		/// <summary>
		/// 定义私有构造函数，使外界不能创建该类实例
		/// </summary>
		private Singleton()
		{
		}

		/// <summary>
		/// 定义公有方法提供一个全局访问点,同时可以定义公有属性来提供全局访问点
		/// </summary>
		/// <returns>返回单体实例</returns>
		public static Singleton GetInstance()
		{
			// 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
			// 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
			// lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
			// 双重锁定只需要一句判断就可以了
			if (uniqueInstance == null)
			{
				lock (locker)
				{
					// 如果类的实例不存在则创建，否则直接返回
					if (uniqueInstance == null)
					{
						uniqueInstance = new Singleton();
					}
				}
			}
			return uniqueInstance;
		}
	}
}
