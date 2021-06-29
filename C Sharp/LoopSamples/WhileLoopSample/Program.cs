using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int Res = 0, i=1;
            while (i < 11)
            {
                Res += i;
                i++;
            }
            Console.WriteLine($"加總結果：{Res}");
            Console.ReadLine();
        }
    }
}
