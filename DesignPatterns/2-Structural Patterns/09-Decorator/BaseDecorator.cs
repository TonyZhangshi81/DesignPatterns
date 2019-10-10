using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseDecorator : BaseHouse
    {
        /// <summary>
        /// 
        /// </summary>
        protected BaseHouse _house;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="house"></param>
        protected BaseDecorator(BaseHouse house)
        {
            this._house = house;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Renovation()
        {
            //this._house.
        }

    }
}
