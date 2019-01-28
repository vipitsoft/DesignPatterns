using System;
namespace Main.工厂模式
{
    public class AddFactory : IFactory
    {

        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }
}
