using System;
namespace Main.工厂模式
{
    public class DivFactory : IFactory
    {
        public DivFactory()
        {
        }

        public Operation CreateOperation()
        {
            return new OperationDiv();
        }
    }
}
