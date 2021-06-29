using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample006
{
    class Program
    {
        public static void Main()
        {
            var list            = new List<string> { "A", "B", "C", "D", "E", "F", "F" };
            var ResulfOfSkip    = list.Skip(3);
            Console.WriteLine($"Skip(3)         的結果：{String.Join("-",ResulfOfSkip)}");
            
            var ResultOfTake    = list.Take(3);
            Console.WriteLine($"Take(3)         的結果：{String.Join("-", ResultOfTake)}");

            var ResultOfSkipTake = list.Skip(2).Take(2);
            Console.WriteLine($"Skip(2).Take(2) 的結果：{String.Join("-", ResultOfSkipTake)}");

            Console.ReadLine();
        }
    }
}
