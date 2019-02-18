using System;
namespace Main.简单工厂模式
{
    /// <summary>
    /// 工厂类
    /// </summary>
    public class OperationFactory
    {
        public static Operation CreateOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
                default:
                    break;
            }
            return oper;
        }
    }
}
