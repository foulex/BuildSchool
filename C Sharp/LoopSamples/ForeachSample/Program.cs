using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5 };
            foreach (int y in array)
            {
                Console.WriteLine(5*y);
            }
            Console.ReadLine();
        }
    }
}
