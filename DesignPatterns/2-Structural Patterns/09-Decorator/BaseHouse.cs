using System.Collections.Generic;

namespace DesignPatterns.DecoratorPattern
{
    /// <summary>
    /// 该抽象类就是房子抽象接口的定义，该类型就相当于是Component类型，需要装饰的，需要包装的
    /// </summary>
    public abstract class BaseHouse
    {
        /// <summary>
        /// 如果不希望房屋改造出现返工，那么这个任务改造状态开关就必须保留
        /// 造成上述情况的原因也正是因为装饰模式中存在的对象嵌套关系
        ///（* Decorator类在接口上表现为is-a Component的继承关系，即Decorator类继承了Component类所具有的接口。但在实现上又表现为has-a Component的组合关系，即Decorator类又使用了另外一个Component类。）
        /// </summary>
        protected bool IsFinish { get; set; }

        /// <summary>
        /// 房屋改造任务列表
        /// </summary>
        /// <remarks>
        /// 需要注意的是此对象的引用需要向下（即子对象）传递，否则会因为对象嵌套的原因，子对象得不到该属性在父类中的引用
        /// 看一下<see cref="BaseDecorator"/>的构造函数
        /// </remarks>
        public List<string> Content { get; set; }

        /// <summary>
        /// 房子的装修方法--该操作相当于Component类型的Operation方法
        /// </summary>
        public abstract void Renovation();
    }
}
