using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數：");
            string input = Console.ReadLine();
            int Nums = int.Parse(input);
            for(int i=0; i != Nums; i++)
            {
                for(int j=0; j <= i; j++)
                {
                    Console.Write(Nums-i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
