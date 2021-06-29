using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個中華民國年分：");
            string input = Console.ReadLine();
            int Year = int.Parse(input)+1911;
            if(Year % 4 != 0)
            {
                Console.WriteLine($"民國{input}年是閏年！");
            }
            else
            {
                Console.WriteLine($"民國{input}年不是閏年！");
            }
            Console.ReadLine();
            //DateTime.IsLeapYear
            //Console.WriteLine((DateTime.IsLeapYear(int.Parse(Console.ReadLine())+1911) ? "是閏年" : "不是閏年"));
        }
    }
}
