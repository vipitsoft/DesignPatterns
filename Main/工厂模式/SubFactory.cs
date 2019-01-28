using System;
namespace Main.工厂模式
{
    public class SubFactory : IFactory
    {
        public SubFactory()
        {
        }

        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
}
