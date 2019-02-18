using System;
namespace Main.装饰器模式
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具体装饰对象B的操作");

        }

        private void AddedBehavior()
        {

        }
    }
}
