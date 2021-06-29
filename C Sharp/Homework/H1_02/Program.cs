using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入任意長度的數字，並以逗號(,)分隔，我會按照奇偶數將其分開排列。");
            string      input   = Console.ReadLine();
            string[]    result  = input.Split(',');
            List<int> N_Odd, N_Even;
            N_Odd = new List<int>();
            N_Even = new List<int>();

            foreach (string check in result)
            {
                int i = int.Parse(check);

                if (i % 2 != 0) N_Odd.Add(i); 
                else            N_Even.Add(i);
            }
            N_Odd.Sort();
            N_Even.Sort();

            Console.Write("奇數：");
            //foreach(int i in N_Odd)     Console.Write($"{i},");
            Console.WriteLine($"{string.Join(",", (N_Odd.Select(x => x)))}");
            Console.WriteLine();

            Console.Write("偶數：");
            //foreach (int i in N_Even)   Console.Write($"{i},");
            Console.WriteLine($"{string.Join(",",(N_Even.Select(x=> x)))}");
            Console.ReadLine();

        }

    }
}
