using System;
using Main.代理模式;
using Main.原型模式;
using Main.工厂模式;
using Main.模版方法模式;
using Main.策略模式;
using Main.简单工厂模式;
using Main.装饰器模式;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 简单工厂调用
            //Operation operation;
            //operation = OperationFactory.CreateOperate("+");
            //operation.NumberA = 1;
            //operation.NumberB = 2;
            //double result = operation.GetResult();
            //Console.WriteLine(result);
            //Console.ReadKey();
            #endregion
            //======================================================================

            #region 策略模式调用
            //double total = 0.0d; // 用于总计
            //CashContext cc = null;
            // 正常收费
            //cc = new CashContext(new CashNormal());
            //double totalPrices = 0d;
            //totalPrices = cc.GetResult(12 * 3);
            //total = total + totalPrices;
            //Console.WriteLine("总价：" + total);
            //Console.ReadKey();

            // 满300返100
            //cc = new CashContext(new CashReturn("300", "100"));
            //double totalPrices = 0d;
            //totalPrices = cc.GetResult(100 * 3);
            //total = total + totalPrices;
            //Console.WriteLine("总价：" + total);
            //Console.ReadKey();

            // 打8折
            //cc = new CashContext(new CashRebate("0.8"));
            //double totalPrices = 0d;
            //totalPrices = cc.GetResult(100 * 3);
            //total = total + totalPrices;
            //Console.WriteLine("总价：" + total);
            //Console.ReadKey();
            #endregion
            //======================================================================

            #region 装饰器模式调用
            //ConcreteComponent c = new ConcreteComponent();
            //ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
            //ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();
            //decoratorA.SetComponent(c);
            //decoratorB.SetComponent(decoratorA);
            //decoratorB.Operation();
            //Console.ReadKey();
            #endregion
            //======================================================================

            #region 代理模式调用
            //SchoolGirl jiaojiao = new SchoolGirl();
            //jiaojiao.Name = "李娇娇";

            //Proxy daili = new Proxy(jiaojiao);
            //daili.GiveDolls();
            //daili.GiveFlowers();
            //daili.GiveFlowers();
            //Console.ReadKey();
            #endregion
            //======================================================================

            #region 工厂模式调用
            //IFactory operFactory = new AddFactory();
            //工厂模式.Operation oper = operFactory.CreateOperation();
            //oper.NumberA = 1;
            //oper.NumberB = 2;
            //double result = oper.GetResult();
            //Console.WriteLine(result);
            //Console.ReadKey();
            #endregion
            //======================================================================

            #region 原型模式
            //Resume a = new Resume("小明");
            //a.SetPersonalInfo("男", "29");
            //a.SetWorkExperience("1998-2000", "xx公司");

            //Resume b = (Resume)a.Clone();
            //b.SetWorkExperience("1998-2006", "YY企业");

            //Resume c = (Resume)a.Clone();
            //c.SetPersonalInfo("男", "24");
            //c.SetWorkExperience("1998-2009", "ZZ企业");

            //a.Display();
            //b.Display();
            //c.Display();

            //Console.ReadKey();
            #endregion
            //======================================================================
            #region 模版方法模式调用
            Console.WriteLine("学生甲答题：");
            TestPaper testPaperA = new TestPaperA();
            testPaperA.TestQuestion1();
            testPaperA.TestQuestion2();
            testPaperA.TestQuestion3();

            Console.WriteLine("学生乙答题：");
            TestPaper testPaperB = new TestPaperB();
            testPaperB.TestQuestion1();
            testPaperB.TestQuestion2();
            testPaperB.TestQuestion3();

            Console.ReadKey();
            #endregion
        }
    }
}
