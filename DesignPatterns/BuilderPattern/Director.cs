namespace DesignPatterns.BuilderPattern
{
	/// <summary>
	/// 指挥创建过程类（建造者模式中的指挥者）
	/// </summary>
	/// <remarks>
	/// 将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。
	/// 实现要点：
	/// 1.在建造者模式中，指挥者是直接与客户端打交道的，指挥者将客户端创建产品的请求划分为对各个部件的建造请求，再将这些请求委派到具体建造者角色，具体建造者角色是完成具体产品的构建工作的，却不为客户所知道。
	/// 2.建造者模式主要用于“分步骤来构建一个复杂的对象”，其中“分步骤”是一个固定的组合过程，而复杂对象的各个部分是经常变化的
	/// 3.产品不需要抽象类，由于建造模式的创建出来的最终产品可能差异很大，所以不大可能提炼出一个抽象产品类。
	/// 4.抽象工厂模式解决了“系列产品”的需求变化，而建造者模式解决的是“产品部分”的需要变化。
	/// 5.由于建造者隐藏了具体产品的组装过程，所以要改变一个产品的内部表示，只需要再实现一个具体的建造者就可以了，从而能很好地应对产品组成组件的需求变化。
	/// 优点：
	/// 建造代码与表示代码的分离，可以使客户端不必知道产品内部组成的细节，从而降低了客户端与具体产品之间的耦合度
	/// </remarks>
	public class Director
	{
		/// <summary>
		/// 电脑组装
		/// </summary>
		/// <param name="builder">组装人员</param>
		public void Construct(BaseBuilder builder)
		{
			builder.BuildPartCPU();
			builder.BuildPartMainBoard();
			builder.BuildPartGraphicsCard();
			builder.BuildPartSoundCard();
		}
	}
}
