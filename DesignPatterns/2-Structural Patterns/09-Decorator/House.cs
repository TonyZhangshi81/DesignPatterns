using System.Collections.Generic;

namespace DesignPatterns.DecoratorPattern
{
    /// <summary>
    /// 定义一个最基本的房屋包装或装饰类，相当于ConcreteComponent类型
    /// </summary>
    public sealed class House : BaseHouse
    {
        /// <summary>
        /// 对象实例化后为其中一些属性做初始化工作
        /// </summary>
        public House()
        {
            IsFinish = false;

            if (this.Content == null)
            {
                this.Content = new List<string>();
            }
        }

        /// <summary>
        /// 基本的装修实现内容
        /// </summary>
        public override void Renovation()
        {
            // 如果任务已经完成了就不需要在返工了（只在对象的生命周期内有效）
            if (!IsFinish)
            {
                this.Content.Add("装修房子");
                IsFinish = true;
            }
        }
    }
}
