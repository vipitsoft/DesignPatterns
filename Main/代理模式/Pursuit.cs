using System;
namespace Main.代理模式
{
    public class Pursuit : GiveGift
    {
        SchoolGirl mm;
        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }
        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + "\t送你的洋娃娃");
        }

        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + "\t送你的鲜花");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + "\t送你的巧克力");
        }
    }
}
