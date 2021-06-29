using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ArrayAndForloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[] { 1, 2, 3, 4, 5 };
            //等同int[] Numbers = {1, 2, 3, 4, 5};

            string[] Words = { "Do", "Re", "Me", "Fa", "So" };  

            for(int i = 0; i < 5; i = i + 1)
            {
                Console.WriteLine($"{Numbers[i]} {Words[i]}");
            }

            Console.ReadLine(); 
        }
    }
}
