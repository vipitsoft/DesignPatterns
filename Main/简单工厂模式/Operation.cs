using System;
namespace Main.简单工厂模式
{
    /// <summary>
    /// 运算类
    /// </summary>
    public class Operation
    {
        /// <summary>
        /// 参数A
        /// </summary>
        /// <value>The number a.</value>
        public double NumberA { get; set; }

        /// <summary>
        /// 参数B
        /// </summary>
        /// <value>The number b.</value>
        public double NumberB { get; set; }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
