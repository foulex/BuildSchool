using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoopSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int Res=0, i=1;
            do
            {
                Res += i;
                i++;
            }
            while (i < 11);
            Console.WriteLine($"加總結果{Res}");
            Console.ReadLine();
        }
    }
}
