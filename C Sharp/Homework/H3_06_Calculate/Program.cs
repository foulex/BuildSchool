using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text.RegularExpressions;

namespace H3_06_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("給我一個整數：");
            int Total = 0, 
                j = 0,
                Nums = int.Parse(Console.ReadLine());

            for(int i = 1 ; i <= Nums ; i++)
            {
                if(i % 2 == 0)j = -i;
                Total += j;
            }
            Console.WriteLine($"總合為{Total}");
            Console.ReadLine();
        }
    }
}
