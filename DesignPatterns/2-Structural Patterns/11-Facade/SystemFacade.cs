using System.Collections.Generic;

namespace DesignPatterns.FacadePattern
{
    /// <summary>
    /// 在外观模式中，外观类Facade的方法OptionWrapper实现的就是以不同的次序调用下面类SubSystem1、SubSystem2的方法Operation，通过不同的Operation组合实现装饰功能。
    /// </summary>
    /// <remarks>
    /// <para>外观模式包含如下两个角色：</para>
    /// <list type="bullet">
    /// <item>外观角色（Facade）
    /// <description>
    /// 在客户端可以调用它的方法，在外观角色中可以知道相关的（一个或者多个）子系统的功能和责任；
    /// 在正常情况下，它将所有从客户端发来的请求委派到相应的子系统去，传递给相应的子系统对象处理。</description>
    /// </item>
    /// <item>
    /// <description>
    /// 在软件系统中可以有一个或者多个子系统角色，每一个子系统可以不是一个单独的类，而是一个类的集合，它实现子系统的功能；
    /// 每一个子系统都可以被客户端直接调用，或者被外观角色调用，它处理由外观类传过来的请求；
    /// 子系统并不知道外观的存在，对于子系统而言，外观角色仅仅是另外一个客户端而已。</description>
    /// </item>
    /// </list>
    /// <para>外观模式适用情形：</para>
    /// <list type="bullet">
    /// <item>当要为一个复杂子系统提供一个简单接口时，子系统往往因为不断演化而变得越来越复杂。
    /// 大多数模式使用时都会产生更多更小的类，这使得子系统更具可用性，也更容易对子系统进行定制。
    /// 但这也给那些不需要定制子系统的用户带来一些使用上的困难。外观模式可以提供一个简单的默认视图。
    /// 这一视图对大多数用户来说已经足够，而那些需要更多定制性的用户可以越过Facade层。</item>
    /// <item>客户程序与抽象类的实现部分之间存在着很大的依赖性。引入外观模式将这个子系统与客户以及其他子系统分离，可以提高该子系统的独立性和可移植性。</item>
    /// <item>当需要构建有层次结构的子系统时，使用外观模式定义每层的入口点。如果子系统间相互依赖，它们只需通过外观进行通信，从而简化它们之间的依赖关系。</item>
    /// </list>
    /// <para>外观模式特点：</para>
    /// <list type="bullet">
    /// <item>它实现了子系统对客户的屏蔽，因而减少了客户处理的对象数目并且使子系统使用起来更加方便。</item>
    /// <item>它实现了子系统与客户之间的松耦合关系。而子系统内部的功能组件往往是紧耦合的。松耦合关系使得子系统的组件变化不会影响到它的客户。</item>
    /// <item>外观模式有助于建立系统的层次结构，也有助于对对象之间的依赖关系分层。</item>
    /// <item>外观模式可以消除复杂的循环依赖关系。这一点在客户程序与子系统是分别实现的时候尤为重要。
    /// 在大型软件系统中降低编译依赖性至关重要。在子系统类改变时，希望尽量减少重编译工作以节省时间。</item>
    /// <item>用外观模式可以降低编译依赖性，减少对重要系统做较小的改变所需的重编译工作。</item>
    /// <item>外观模式有利于简化系统在不同平台之间的移植过程。因为编译一个子系统一般不需要编译所有其他子系统。</item>
    /// <item>如果应用需要，外观模式并不限制子系统类的使用。因此可以在系统易用性和通用性之间加以选择。</item>
    /// </list>
    /// </remarks>
    public class SystemFacade
    {
        /// <summary>
        /// 身份验证子系统
        /// </summary>
        private readonly AuthoriationSystem _authoriationSystem;

        /// <summary>
        /// 系统安全子系统
        /// </summary>
        private readonly SecuritySystem _securitySystem;

        /// <summary>
        /// 网银安全检查子系统
        /// </summary>
        private readonly NetBankSystem _netBankSystem;

        /// <summary>
        /// 操作LOG
        /// </summary>
        private readonly List<string> _log;

        /// <summary>
        /// 初期化构造
        /// </summary>
        public SystemFacade()
        {
            _authoriationSystem = new AuthoriationSystem();
            _securitySystem = new SecuritySystem();
            _netBankSystem = new NetBankSystem();

            _log = new List<string>();
        }

        /// <summary>
        /// 为一个复杂子系统提供一个简单接口
        /// </summary>
        public void Buy()
        {
            _log.Add(_authoriationSystem.Method());
            _log.Add(_securitySystem.Method());
            _log.Add(_netBankSystem.Method());

            _log.Add("购买处理完成");
        }

        /// <summary>
        /// 
        /// </summary>
        public List<string> Log
        {
            get { return _log; }
        }
    }
}
