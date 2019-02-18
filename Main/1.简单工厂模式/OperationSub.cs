using System;
namespace Main.简单工厂模式
{
    /// <summary>
    /// 减法类
    /// </summary>
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
}
