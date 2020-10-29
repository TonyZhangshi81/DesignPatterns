using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyweightPattern
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseSwordsman
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public BaseSwordsman(string name)
        {
            Name = name;
        }


    }
}
