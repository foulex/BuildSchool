using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadThenDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("請輸入文字：");
            input = Console.ReadLine();
            Console.Write($"你輸入的是：\n{input}");
            //Console.WriteLine(input);
            Console.ReadLine();
        }
    }
}
