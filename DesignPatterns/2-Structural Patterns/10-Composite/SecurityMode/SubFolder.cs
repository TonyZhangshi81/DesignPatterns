using System.Collections.Generic;

namespace DesignPatterns.CompositePattern.SecurityMode
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class SubFolder : NextFolder
    {
        /// <summary>
        /// 
        /// </summary>
        private List<Folder> _children = new List<Folder>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public SubFolder(string name) : base(name)
        {
        }

        /// <summary>
        /// 添加文件或者文件夹
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public override void Add(Folder folder)
        {
            _children.Add(folder);
        }

        /// <summary>
        /// 打开文件夹--该操作相当于Component类型的Operation方法
        /// </summary>
        public override void Open()
        {
            Folder.TreeList.Add(_name);
            foreach (Folder component in _children)
            {
                component.Open();
            }
        }

        /// <summary>
        /// 删除文件或者文件夹
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public override void Remove(Folder folder)
        {
            _children.Remove(folder);
        }
    }
}
