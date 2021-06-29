using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new Class1();
            o.Exec();
            Console.ReadLine();
        }
    }
    public class Class1
    {
        [ObsoleteAttribute("喵"/*,true*/)]
        public void Exec() { }
        public void Begin() { }
    }

}
