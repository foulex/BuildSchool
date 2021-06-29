using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Nums = { 6, 7, 8, 9, 10 };

            /*for each，將變數in陣列
             *while，先判斷再做
             *do while，先做再判斷
             */
            foreach(int item in Nums)
            {
                Console.WriteLine(item);
            }

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(Nums[i]);
                i++;
            }

            while (true)
            {
                Console.WriteLine(i);
                i++;
                if (i == 10 ) break;
            }
            //do while
            int j = 0;
            do
            {
                Console.WriteLine(Nums[j]);
                j++;

            }
            while (j < 5);
            Console.ReadLine();
        }
    }
}
