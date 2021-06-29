using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IfElse
{
    class Program
    {
        /*運算子筆記
        比較運算子
        ==
        >
        <
        >=
        <=
        !=
         */
        static void Main(string[] args)
        {
            int SA = 50;
            int SB = 60;
            int SC = 70;
            string name;

            if (SA > SB)
            {
                if (SA > SC)
                    name = "A";

                else
                    name = "C";
            }
            else
            {
                if (SB > SC)
                    name = "B";

                else                
                    name = "C";               
            }
            Console.WriteLine($"{name}");
            Console.ReadLine();
        }
    }
}
