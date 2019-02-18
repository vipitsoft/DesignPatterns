using System;
namespace Main.模版方法模式
{
    public class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("杨过得到，后来给了郭靖，炼成倚天剑、屠龙刀的玄铁可能是[ ] \n a.球磨铸铁 \n b.马口铁 \n c.高速合金钢 \n d.碳素纤维");
            Console.WriteLine("答案：" + Answer1());
        }

        public void TestQuestion2()
        {
            Console.WriteLine("杨过、程英、陆无双铲除了情花，造成了[ ] \n a.是这种植物不再害人。\n b.使一种珍稀物种灭绝 \n c.破坏了那个生物圈的生态平衡. \n d.造成该地区沙漠化");
            Console.WriteLine("答案：" + Answer2());
        }

        public void TestQuestion3()
        {
            Console.WriteLine(" 蓝凤凰致使华山师徒、桃谷六仙呕吐不止，如果你是大夫，会给他们开什么药[ ] \n a.阿司匹林 \n b.牛黄解毒片 \n c.氟哌酸 \n d.让他们喝大量的生牛奶 \n e.以上全不对。");
            Console.WriteLine("答案：" + Answer3());
        }

        protected virtual string Answer1()
        {
            return "";
        }

        protected virtual string Answer2()
        {
            return "";
        }

        protected virtual string Answer3()
        {
            return "";
        }
    }
}