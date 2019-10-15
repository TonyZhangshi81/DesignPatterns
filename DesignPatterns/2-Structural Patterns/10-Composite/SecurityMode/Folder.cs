using System.Collections.Generic;

namespace DesignPatterns.CompositePattern.SecurityMode
{
    /// <summary>
    /// 该抽象类就是文件夹抽象接口的定义，该类型就相当于是抽象构件Component类型
    /// </summary>
    /// <remarks>
    /// 组合模式有两种实现方式，一种是：透明式的组合模式，另外一种是：安全式的组合模式。
    /// 所谓安全式是指“抽象构件角色”只定义叶子对象的方法，确切的说这个抽象构件只定义两类对象共有的行为，然后容器对象的方法定义在“树枝构件角色”上，
    /// 这样叶子对象有叶子对象的方法，容器对象有容器对象的方法，这样责任很明确，当然调用肯定不会抛出异常了。
    /// <para>组合模式的实现要点：</para>
    /// <list type="bullet">
    /// <item>1.Composite模式采用树形结构来实现普遍存在的对象容器，从而将“一对多”的关系转化为“一对一”的关系，使得客户代码可以一致地处理对象和对象容器，无需关心处理的是单个的对象，还是组合的对象容器。</item>
    /// <item>2.将“客户代码与复杂的对象容器结构”解耦是Composite模式的核心思想，解耦之后，客户代码将与纯粹的抽象接口——而非对象容器的复杂内部实现结构——发生依赖关系，从而更能“应对变化”。</item>
    /// <item>3.Composite模式中，是将“Add和Remove等和对象容器相关的方法”定义在“表示抽象对象的Component类”中，还是将其定义在“表示对象容器的Composite类”中，是一个关乎“透明性”和“安全性”的两难问题，需要仔细权衡。
    /// 这里有可能违背面向对象的“单一职责原则”，但是对于这种特殊结构，这又是必须付出的代价。ASP.Net控件的实现在这方面为我们提供了一个很好的示范。</item>
    /// <item>4.Composite模式在具体实现中，可以让父对象中的子对象反向追朔；如果父对象有频繁的遍历需求，可使用缓存技巧来改善效率。</item>
    /// </list>
    /// <para>组合模式的优点：</para>
    /// <list typ="bullet">
    /// <item>1.组合模式使得客户端代码可以一致地处理对象和对象容器，无需关系处理的单个对象，还是组合的对象容器。</item>
    /// <item>2.将”客户代码与复杂的对象容器结构“解耦。</item>
    /// <item>3.可以更容易地往组合对象中加入新的构件。</item>
    /// </list>
    /// <para>组合模式的缺点：</para>
    /// <list typ="bullet">
    /// <item>1.使得设计更加复杂。客户端需要花更多时间理清类之间的层次关系。（这个是几乎所有设计模式所面临的问题）。</item>
    /// </list>
    /// <para>在以下情况下应该考虑使用组合模式：</para>
    /// <list typ="bullet">
    /// <item>1.需要表示一个对象整体或部分的层次结构。</item>
    /// <item>2.希望用户忽略组合对象与单个对象的不同，用户将统一地使用组合结构中的所有对象。</item>
    /// </list>
    /// </remarks>
    public abstract class Folder
    {
        private static List<string> _treeList;

        private static readonly object locker = new object();

        /// <summary>
        /// 定义公有方法提供一个全局访问点,同时可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns>返回单体实例</returns>
        public static List<string> TreeList
        {
            get
            {
                if (_treeList == null)
                {
                    lock (locker)
                    {
                        // 如果类的实例不存在则创建，否则直接返回
                        if (_treeList == null)
                        {
                            _treeList = new List<string>();
                        }
                    }
                }
                return _treeList;
            }
            private set { }
        }

        protected string _name;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Folder(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// 打开文件或者文件夹--该操作相当于Component类型的Operation方法
        /// </summary>
        public abstract void Open();
    }
}
