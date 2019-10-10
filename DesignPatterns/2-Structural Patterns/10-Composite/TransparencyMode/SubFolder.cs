using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern.TransparencyMode
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class SubFolder : Folder
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
        /// <param name="depth"></param>
        /// <returns></returns>
        public override string Open(int depth)
        {
            var content = new StringBuilder();

            content.AppendLine(string.Format("{0} {1}", new String('-', depth), _name));

            foreach (Folder component in _children)
            {
                content.AppendLine(component.Open(depth + 1));
            }

            return content.ToString();
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
