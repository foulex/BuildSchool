using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            SaySomething("Build");
            Console.WriteLine($"{Add(1,2)}");
            Console.ReadLine();
        }
        //void，無回傳值(JASS裡的return nothing)
        static void SaySomething(string Word)
        {
            Console.WriteLine(Word);
        }
        //，有回傳值
        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
