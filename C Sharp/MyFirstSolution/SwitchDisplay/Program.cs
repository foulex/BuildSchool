using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個數字：");
            int Num = int.Parse(Console.ReadLine());
            switch (Num)
            {
                case 1:
                    Console.WriteLine("是1");
                    break;
                case 2:
                    Console.WriteLine("是2");
                    break;
                default:
                    Console.WriteLine("論外");
                    break;
            }

            Console.ReadLine();
        }
    }
}
