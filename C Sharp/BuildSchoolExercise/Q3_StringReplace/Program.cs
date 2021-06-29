using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            將1~100顯示在畫面上，但是
            如果遇到2的倍數，顯示螃蟹
            如果遇到3的倍數，顯示章魚
            如果同時為2與3的倍數，顯示金槍魚
            */
            string output;
            for (int i = 1; i<=100; i++)
            {
                output = Convert.ToString(i);
                if ((i % 2) == 0)
                {
                    output = ("螃蟹");
                }

                if ((i % 3) == 0)
                 {
                        output = ("章魚");
                 }

                if ((i % 6) == 0)
                 {
                        output = ("金槍魚");
                 }                  
                
                Console.WriteLine($"{output}");
            }
            Console.ReadLine();
        }
    }
}
