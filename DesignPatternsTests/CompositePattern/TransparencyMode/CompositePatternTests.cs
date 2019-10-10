using DesignPatterns.CompositePattern.TransparencyMode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTests.CompositePattern.TransparencyMode
{
    /// <summary>
	/// 组合模式测试类
	/// </summary>
	[TestClass()]
    public class CompositePatternTests
    {
        /// <summary>
        /// 
        /// </summary>
        public void CompositeTest01()
        {
            var root = new SubFolder("根目录 A");
            root.Add(new File("文件 A"));
            root.Add(new File("文件 B"));

            var comp = new SubFolder("子目录 X");
            comp.Add(new File("文件 XA"));
            comp.Add(new File("文件 XB"));

            root.Add(comp);
            root.Add(new File("文件 C"));

            var leaf = new File("文件 D");
            root.Add(leaf);
            root.Remove(leaf);

            var content = root.Open(2);
        }
    }
}
