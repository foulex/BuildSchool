using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一句話：");
            string input = Console.ReadLine();

            Console.WriteLine($"剛剛輸入：{input}");

            Console.ReadLine();
        }
    }
}
