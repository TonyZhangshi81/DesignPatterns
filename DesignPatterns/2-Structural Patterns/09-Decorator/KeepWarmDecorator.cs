namespace DesignPatterns.DecoratorPattern
{
    /// <summary>
    /// 具有保温接口的材料，提供保温功能，相当于ConcreteDecoratorB类型
    /// </summary>
    public sealed class KeepWarmDecorator : BaseDecorator
    {
        /// <summary>
        /// 通过构造器注入，初始化平台实现
        /// </summary>
        /// <param name="house"></param>
        public KeepWarmDecorator(BaseHouse house) : base(house)
        {
            IsFinish = false;
        }

        /// <summary>
        /// 重写房屋改造方法，在原有的装修内容之上加入新的改造内容
        /// </summary>
        public override void Renovation()
        {
            // 完成基本的装修任务
            base.Renovation();

            if (this._house != null && !IsFinish)
            {
                // 增加保温的功能
                this._house.Content.Add("增加保温的功能");
                IsFinish = true;
            }
        }
    }
}
