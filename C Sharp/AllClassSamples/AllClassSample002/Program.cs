using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSample002
{
    class Program
    {
        static void Main()
        {
            BaseClass o1 = new Class1();
            o1.Execute();
            o1.Begin();

            BaseClass o2 = new Class2();
            o2.Execute();
            o2.Begin();

            Console.ReadLine();
        }
    }

    public class BaseClass
    {
        public virtual void Execute()
        {
            Console.WriteLine("Base Execute Method");
        }
        public virtual void Begin()
        {
            Console.WriteLine("Base Begin Method");
        }
    }
    public class Class1 : BaseClass
    {
        public override void Execute()
        {
            Console.WriteLine("Class1 Execute Method");
        }
    }

    public class Class2 : Class1
    {
        public sealed override void Execute()
        {
            Console.WriteLine("Class2 Execute Method");
        }
        public override void Begin()
        {
            Console.WriteLine("Class2 Begin Method");
        }
    }
    public class Class3 : Class2
    {
        //測試sealed
        public override void Execute()
        {
            Console.WriteLine("Class3 Execute Method");
        }
        public override void Begin()
        {
            Console.WriteLine("Class3 Begin Method");
        }
    }
}