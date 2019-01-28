using System;
namespace Main.策略模式
{
    /// <summary>
    /// 现金收费抽象类
    /// </summary>
    public abstract class CashSuper
    {
        public abstract double AcceptCash(double money);
    }
}
