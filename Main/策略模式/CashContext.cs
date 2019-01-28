using System;
namespace Main.策略模式
{
    public class CashContext
    {
        private CashSuper cs;

        public CashContext(CashSuper cashSuper)
        {
            this.cs = cashSuper;
        }

        public double GetResult(double money)
        {
            return cs.AcceptCash(money);
        }
    }
}
