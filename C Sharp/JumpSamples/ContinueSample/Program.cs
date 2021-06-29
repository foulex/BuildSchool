using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cond = 15;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 11; j < 20; j++)
                {
                    if (j == Cond)
                    {
                        continue;
                    }
                    Console.WriteLine($"j = {j}");
                }
            }
            Console.ReadLine();
        }
    }
}
