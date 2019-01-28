using System;
namespace Main.工厂模式
{
    public class MulFactory : IFactory
    {
        public MulFactory()
        {
        }

        public Operation CreateOperation()
        {
            return new OperationMul();
        }
    }
}
