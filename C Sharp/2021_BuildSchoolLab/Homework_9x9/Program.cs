using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9x9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---第一版---");
            //1
            for (int i = 1; i< 10; i++)
            {
                for (int j=1; j<10; j++)
                {
                    Console.WriteLine($"{i}*{j}={i*j}");
                }
            }
            Console.WriteLine("---第二版---");
            //2
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i}*{j}={i * j}");
                    if (j < 9)
                    {
                        Console.Write("\t");
                    }
                    else Console.Write("\n");
                }
            }
            Console.WriteLine("---第三版---");
            //3
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{j}*{i}={i * j}");
                    if (j < 9)
                    {
                        Console.Write("\t");
                    }
                    else Console.Write("\n");
                }
            }
            Console.WriteLine("-----");
            
            //-----
            Console.ReadLine();
        }
    }
}
