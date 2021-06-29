using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample003
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            var list2 = new List<int> { 1, 3, 4, 7, 8, 9 };

            //D4_03
            var union = list1.Union(list2);
            Console.WriteLine($"A聯集B結果為：{string.Join(" ", union)}");

            var intersect = list1.Intersect(list2);
            Console.WriteLine($"A交集B結果為：{string.Join(" ", intersect)}");

            Console.ReadLine();

            //--------------------------------------------------------------

            //D4_04
            var aEXb = list1.Except(list2);
            Console.WriteLine($"A差集B的結果為：{string.Join(" ", aEXb)}");

            var bEXa = list2.Except(list1);
            Console.WriteLine($"B差集A的結果為：{string.Join(" ", bEXa)}");

            Console.ReadLine();

            //--------------------------------------------------------------

            //D4_05
            //Distinct=排除重複
            var list05 = new List<string> { "台北", "台北", "洛杉磯", "紐約", "紐約", "台北" };
            var result05 = list05.Distinct();
            Console.WriteLine($"排除重複結果為：{string.Join(" ", result05)}");

            Console.ReadLine();

        }
    }
}
