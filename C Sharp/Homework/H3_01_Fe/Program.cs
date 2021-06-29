using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4_01_費氏數列
{
    class Program
    {
        static void Main(string[] args)
        {
            long A = 0, B = 1, C = 1;
            do 
            {
                Console.WriteLine(C.ToString());
                C = A + B;
                A = B;
                B = C;             
            } while (C <= 1836311903);
            Console.ReadLine();
        }

        /* 助教寫法
         * int x=0,y=1;
         * static void PLUS(int x, int y)
         * {
         * if(x>1836311903)return;
         * Console.WriteLine(y);
         * PLUS(y=y+x);
         * }
         */ 
    }
}
