using System;
namespace Main.策略模式
{
    /// <summary>
    /// 返利收费子类
    /// </summary>
    public class CashReturn : CashSuper
    {
        private double moneyCondition = 0.0d;

        private double moneyReturn = 0.0d;

        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }

        public override double AcceptCash(double money)
        {
            double result = money;
            if (money >= moneyCondition)
                return money - Math.Floor(money / moneyCondition) * moneyReturn;

            return result;
        }
    }
}
