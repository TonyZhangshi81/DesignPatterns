namespace DesignPatterns.DecoratorPattern
{
    /// <summary>
    /// 具有安全功能的设备，可以提供监视和报警功能，相当于ConcreteDecoratorA类型
    /// </summary>
    public sealed class HouseSecurityDecorator : BaseDecorator
    {
        /// <summary>
        /// 通过构造器注入，初始化平台实现
        /// </summary>
        /// <param name="house"></param>
        public HouseSecurityDecorator(BaseHouse house) : base(house)
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
                // 增加安全系统
                this._house.Content.Add("增加安全系统");
                IsFinish = true;
            }
        }
    }
}
