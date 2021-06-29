using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的字串，我會將其反向顯示：");
            string input = Console.ReadLine();
            string[] result = input.Split(',');
            List<string> Lines;
            Lines = new List<string>();
            foreach (string S in result)
            {
                Lines.Add(S);
            }
            Lines.Reverse();
            Console.Write("結果：");
            foreach (string S in Lines)
            {
                Console.Write($"{S},");
            }
            Console.ReadLine();


            //方法2
            Console.Write("input:");
            string              Ainput  = Console.ReadLine();
            string[]            s_input = Ainput.Split();
            IEnumerable<string> r_input = s_input.Reverse();
            string              output  = string.Join(", ", r_input);
            Console.WriteLine($"結果：{output}");
            Console.ReadLine();
        }
    }
}
