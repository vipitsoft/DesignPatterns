using System;
namespace Main.工厂模式
{
    /// <summary>
    /// 乘法类
    /// </summary>
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
}
