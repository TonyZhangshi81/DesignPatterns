namespace DesignPatterns.PrototypePattern
{
	/// <summary>
	/// 颜色的原型类
	/// </summary>
	/// <remarks>
	/// 原型模式
	/// 当创建一个类的实例的过程很昂贵或很复杂的时候（有时并不是像使用new这么简单操作就能完成的）可以使用原型模式减少内存的消耗和达到类实例的复用
	/// 优点：
	/// 1.向客户隐藏了创建新实例的复杂性
	/// 2.允许动态增加或较少产品类。
	/// 3.原型模式简化了实例的创建结构，工厂方法模式需要有一个与产品类等级结构相同的等级结构，而原型模式不需要这样。
	/// 4.品类不需要事先确定产品的等级结构，因为原型模式适用于任何的等级结构
	/// 缺点：
	/// 1.每个类必须配备一个克隆方法
	/// 2.配备克隆方法需要对类的功能进行通盘考虑，这对于全新的类不是很难，但对于已有的类不一定很容易，特别当一个类引用不支持串行化的间接对象，或者引用含有循环结构的时候。
	/// 要点：
	/// 深克隆时需要将类标记为Serializable <seealso cref="Color"/>
	/// </remarks>
	public abstract class ColorPrototype
	{
		/// <summary>
		/// 原型类克隆方法
		/// </summary>
		/// <returns>返回拷贝后对象</returns>
		public abstract ColorPrototype Clone();
	}
}
