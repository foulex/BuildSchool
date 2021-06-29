using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 200;
            for(int i = 2; i <= max; i++) 
            { 
                for(int j =2; j <= i; j++)
                {
                    if ((i % j) == 0)
                    {
                        if (i == j)
                        {
                        Console.WriteLine($"{i}是質數");
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
