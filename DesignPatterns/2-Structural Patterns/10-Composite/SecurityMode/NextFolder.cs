namespace DesignPatterns.CompositePattern.SecurityMode
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class NextFolder : Folder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public NextFolder(string name) : base(name)
        {
        }

        /// <summary>
        /// 增加文件夹或者文件
        /// </summary>
        /// <param name="folder"></param>
        public abstract void Add(Folder folder);

        /// <summary>
        /// 删除文件夹或者文件
        /// </summary>
        /// <param name="folder"></param>
        public abstract void Remove(Folder folder);
    }
}
