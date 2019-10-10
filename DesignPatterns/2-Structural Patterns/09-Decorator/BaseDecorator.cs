namespace DesignPatterns.DecoratorPattern
{
    /// <summary>
    /// 该抽象类就是装饰接口的定义，该类型就相当于是Decorator类型，如果需要具体的功能，可以子类化该类型
    /// </summary>
    /// <remarks>
    /// 关键点之二，体现关系为Is-a，有这个关系，装饰的类也可以继续装饰了
    /// <para>装饰模式的实现要点：</para>
    /// <list type="bullet">
    /// <item>1.通过采用组合、而非继承的手法，Decorator模式实现了在运行时动态地扩展对象功能的能力，而且可以根据需要扩展多个功能。避免了单独使用继承带来的“灵活性差”和“多子类衍生问题”。</item>
    /// <item>2.Component类在Decorator模式中充当抽象接口的角色，不应该去实现具体的行为。而且Decorator类对于Component类应该透明——换言之Component类无需知道Decorator类，Decorator类是从外部来扩展Component类的功能。</item>
    /// <item>3.Decorator类在接口上表现为is-a Component的继承关系，即Decorator类继承了Component类所具有的接口。但在实现上又表现为has-a Component的组合关系，即Decorator类又使用了另外一个Component类。我们可以使用一个或者多个Decorator对象来“装饰”一个Component对象，且装饰后的对象仍然是一个Component对象。</item>
    /// <item>4.Decorator模式并非解决“多子类衍生的多继承”问题，Decorator模式应用的要点在于解决“主体类在多个方向上的扩展功能”——是为“装饰”的含义。</item>
    /// </list>
    /// <para>装饰模式的优点：</para>
    /// <list type="bullet">
    /// <item>1.把抽象接口与其实现解耦。</item>
    /// <item>2.抽象和实现可以独立扩展，不会影响到对方。</item>
    /// <item>3.实现细节对客户透明，对用于隐藏了具体实现细节。</item>
    /// </list>
    /// <para>装饰模式的缺点：</para>
    /// <list type="bullet">
    /// <item>1.增加了系统的复杂度</item>
    /// </list>
    /// <para>在以下情况下应当使用桥接模式：</para>
    /// <list type="bullet">
    /// <item>1.如果一个系统需要在构件的抽象化角色和具体化角色之间添加更多的灵活性，避免在两个层次之间建立静态的联系。</item>
    /// <item>2.设计要求实现化角色的任何改变不应当影响客户端，或者实现化角色的改变对客户端是完全透明的。</item>
    /// <item>3.需要跨越多个平台的图形和窗口系统上。</item>
    /// <item>4.一个类存在两个独立变化的维度，且两个维度都需要进行扩展。</item>
    /// </list>
    /// </remarks>
    public abstract class BaseDecorator : BaseHouse
    {
        /// <summary>
        /// 通过组合方式引用Decorator类型，该类型实施具体功能的增加
        /// 这是关键点之一，包含关系，体现为Has-a
        /// </summary>
        protected BaseHouse _house;

        /// <summary>
        /// 通过构造器注入，初始化平台实现
        /// </summary>
        /// <param name="house"></param>
        protected BaseDecorator(BaseHouse house)
        {
            this._house = house;
            // 为了维持任务列表的唯一性，顾将保留对上一层父类中任务列表对象的引用
            this.Content = house.Content;
        }

        /// <summary>
        /// 该方法就相当于Decorator类型的Operation方法
        /// </summary>
        /// <remarks>
        /// 注意：为防止待改造对象house没有实例可以引入自定义异常进行check处理（此处省略）
        /// </remarks>
        public override void Renovation()
        {
            if (this._house != null)
            {
                this._house.Renovation();
            }
        }
    }
}
