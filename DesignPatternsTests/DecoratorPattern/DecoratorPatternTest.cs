using DesignPatterns.DecoratorPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTests.DecoratorPattern
{
    /// <summary>
	/// 装饰模式测试类
	/// </summary>
	[TestClass()]
    public class DecoratorPatternTest
    {
        /// <summary>
		/// 房屋改造测试
		/// </summary>
		[TestMethod()]
        public void DecoratorPatternTest01()
        {
            // 需要装饰的房子
            var house = new House();

            BaseDecorator securityHouse = new HouseSecurityDecorator(house);
            // 房子就有了安全系统了
            securityHouse.Renovation();

            Assert.AreEqual(house.Content[0], "装修房子");
            Assert.AreEqual(house.Content[1], "增加安全系统");

            // 如果我既要安全系统又要保暖呢，继续装饰就行
            BaseDecorator securityAndWarmHouse = new KeepWarmDecorator(securityHouse);
            securityAndWarmHouse.Renovation();

            Assert.AreEqual(house.Content[0], "装修房子");
            Assert.AreEqual(house.Content[1], "增加安全系统");
            Assert.AreEqual(house.Content[2], "增加保温的功能");
        }
    }
}
