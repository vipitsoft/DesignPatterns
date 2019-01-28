using System;
namespace Main.原型模式
{
    public class WorkExperience : ICloneable
    {
        public string WorkDate { get; set; }

        public string Company { get; set; }

        public object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
