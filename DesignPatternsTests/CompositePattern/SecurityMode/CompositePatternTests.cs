using DesignPatterns.CompositePattern.SecurityMode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTests.CompositePattern.SecurityMode
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
            root.Add(new File("文件 AA"));
            root.Add(new File("文件 AB"));
            root.Add(new File("文件 AC"));

            var leaf = new File("文件 AD");
            root.Add(leaf);

            var comp = new SubFolder("子目录 X");
            comp.Add(new File("文件 XA"));
            comp.Add(new File("文件 XB"));

            root.Add(comp);
            root.Remove(leaf);

            root.Open();
            Assert.AreEqual(7, Folder.TreeList.Count);
            Assert.AreEqual("根目录 A", Folder.TreeList[0]);
            Assert.AreEqual("文件 AA", Folder.TreeList[1]);
            Assert.AreEqual("文件 AB", Folder.TreeList[2]);
            Assert.AreEqual("文件 AC", Folder.TreeList[3]);
            Assert.AreEqual("子目录 X", Folder.TreeList[4]);
            Assert.AreEqual("文件 XA", Folder.TreeList[5]);
            Assert.AreEqual("文件 XB", Folder.TreeList[6]);
        }
    }
}
