using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstInheritSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o1 = new Class1();
            Class1 o2 = new Class1();
            Class1 o3 = o2;
            bool result = o1.Equals(o2);
            Console.WriteLine($"o1.Equals(o2)={result}");
            Console.WriteLine($"o2.Equals(o3)={o2.Equals(o3)}");

            //StringBuilder builder = new StringBuilder();
            //for(int i=0 ; i < 100 ; i++)
            //{
            //  builder.Append(i.ToString());
            //}
            //builder.ToString();
            //如何不過度占用記憶體空間的字串迴圈法

            Console.ReadLine();
        }
    }
    class Class1
    {

    }
}
