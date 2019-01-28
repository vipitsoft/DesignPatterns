using System;
namespace Main.策略模式
{
    /// <summary>
    /// 正常收费子类
    /// </summary>
    public class CashNormal : CashSuper
    {

        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}
