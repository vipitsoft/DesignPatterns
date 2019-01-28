using System;
namespace Main.策略模式
{
    /// <summary>
    /// 打折收费子类
    /// </summary>
    public class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;

        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }

        public override double AcceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
