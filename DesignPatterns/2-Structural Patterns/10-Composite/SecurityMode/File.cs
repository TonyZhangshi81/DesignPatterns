namespace DesignPatterns.CompositePattern.SecurityMode
{
    /// <summary>
    /// 该Word文档类就是叶子构件的定义，该类型就相当于是Leaf类型，不能在包含子对象
    /// </summary>
    public sealed class File : Folder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public File(string name) : base(name)
        {
        }

        /// <summary>
        /// 打开文件--该操作相当于Component类型的Operation方法
        /// </summary>
        public override void Open() => Folder.TreeList.Add(_name);
    }
}
