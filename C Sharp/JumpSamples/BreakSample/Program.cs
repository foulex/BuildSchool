using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int Con = 15;
            for (int x=0; x<3; x++)
            {
                Console.WriteLine($"X = {x}");
                for (int j= 11; j < 20; j++)
                {
                    if (j== Con)
                    {
                        break;
                    }
                    Console.WriteLine($"j = {j}");
                }
            }
            Console.ReadLine();
        }
    }
}
