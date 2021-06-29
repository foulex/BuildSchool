using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1.Execute();
            Console.ReadLine();
        }
    }
    public static class Class1
    {
        static int x = 100;

        public static void Execute()
        {
            Console.WriteLine($"This is {x}");
        }
    }
}
