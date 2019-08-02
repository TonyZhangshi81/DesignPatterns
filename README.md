## DesignPatterns
## 设计模式备忘录

# 创建型模式<br/>
(1)——单例模式（Singleton Pattern）<br/>
(2)——简单工厂模式（Simple Factory Pattern）<br/>
(3)——工厂方法模式（Factory Method Pattern）<br/>
(4)——抽象工厂模式（Abstract Factory Pattern）<br/>
(5)——建造者模式（Builder Pattern）<br/>
(6)——原型模式（Prototype Pattern）<br/>
<br/>
# 结构型模式<br/>
(7)——适配器模式（Adapter Pattern）<br/>
(8)——桥接模式（Bridge Pattern） <br/>
(9)——装饰者模式（Decorator Pattern）<br/>
(10)——组合模式（Composite Pattern）<br/>
(11)——外观模式（Facade Pattern）<br/>
(12)——享元模式（Flyweight Pattern）<br/>
(13)——代理模式（Proxy Pattern）<br/>
<br/>
# 行为型模式<br/>
(14)——模板方法模式（Template Method）<br/>
(15)——命令模式（Command Pattern）<br/>
(16)——迭代器模式（Iterator Pattern）<br/>
(17)——观察者模式（Observer Pattern）<br/>
(18)——中介者模式（Mediator Pattern）<br/>
(19)——状态者模式（State Pattern）<br/>
(20)——策略者模式（Stragety Pattern）<br/>
(21)——责任链模式（Chain of Responsibility Pattern）<br/>
(22)——访问者模式（Vistor Pattern）<br/>
(23)——备忘录模式（Memento Pattern）<br/>
<br/>
<br/>
## 设计原则：
使用设计模式的根本原因是适应变化，提高代码复用率，使软件更具有可维护性和可扩展性。
在进行设计的时候，还需要遵循以下几个原则：单一职责原则、开放封闭原则、里氏代替原则、依赖倒置原则、接口隔离原则、合成复用原则和迪米特法则。

# .单一职责原则
就一个类而言，应该只有一个引起它变化的原因。如果一个类承担的职责过多，就等于把这些职责耦合在一起，一个职责的变化可能会影响到其他的职责，另外，把多个职责耦合在一起，也会影响复用性。

# .开闭原则(Open-Closed Principle)
该原则强调的是：一个软件实体（指的类、函数、模块等）应该对扩展开放，对修改关闭。即每次发生变化时，要通过添加新的代码来增强现有类型的行为，而不是修改原有的代码。符合开闭原则的最好方式是提供一个固有的接口，然后让所有可能发生变化的类实现该接口，让固定的接口与相关对象进行交互。

# .里氏代替原则(Liskov Substitution Principle, LSP)
指的是子类必须替换掉它们的父类型。在软件开发过程中，子类替换父类后，程序的行为是一样的。只有当子类替换掉父类后，此时软件的功能不受影响时，父类才能真正地被复用，而子类也可以在父类的基础上添加新的行为

# .依赖倒置原则(Dependence Inversion Principle, DIP)
指的是抽象不应该依赖于细节，细节应该依赖于抽象，也就是提出的 “面向接口编程，而不是面向实现编程”。这样可以降低客户与具体实现的耦合。

# .接口隔离原则(Interface Segregation Principle, ISP)
指的是使用多个专门的接口比使用单一的总接口要好。不要让一个单一的接口承担过多的职责，而应把每个职责分离到多个专门的接口中，进行接口分离。过于臃肿的接口是对接口的一种污染。

# .合成复用原则(Composite Reuse Principle, CRP)
在一个新的对象里面使用一些已有的对象，使之成为新对象的一部分。新对象通过向这些对象的委派达到复用已用功能的目的。简单地说，就是要尽量使用合成/聚合，尽量不要使用继承。要使用好合成复用原则，首先需要区分"Has—A"和“Is—A”的关系。“Is—A”是指一个类是另一个类的“一种”，是属于的关系，而“Has—A”则不同，它表示某一个角色具有某一项责任。导致错误的使用继承而不是聚合的常见的原因是错误地把“Has—A”当成“Is—A”。

# .迪米特法则(Law of Demeter，LoD)
又叫最少知识原则（Least Knowledge Principle，LKP），指的是一个对象应当对其他对象有尽可能少的了解。也就是说，一个模块或对象应尽量少的与其他实体之间发生相互作用，使得系统功能模块相对独立，这样当一个模块修改时，影响的模块就会越少，扩展起来更加容易。
关于迪米特法则其他的一些表述有：只与你直接的朋友们通信；不要跟“陌生人”说话。
外观模式（Facade Pattern)和中介者模式（Mediator Pattern）就使用了迪米特法则。




