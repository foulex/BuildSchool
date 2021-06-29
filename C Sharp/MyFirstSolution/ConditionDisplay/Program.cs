using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, Con=10;
            string Ans;
            Console.Write("請輸入一個數字：");
            Num = int.Parse(Console.ReadLine());
            if      (Num > Con)
            { Ans = "大"; }
            else if (Num < Con)
            { Ans = "小"; }
            else
            { Ans = "等"; }

            Console.WriteLine($"您輸入的值{Num}{Ans}於{Con}");
            Console.ReadLine();
        }
    }
}
