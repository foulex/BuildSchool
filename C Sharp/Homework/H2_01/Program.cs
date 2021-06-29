using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_01
{
    //class Nums
    //{
    //    public string Numbers { get; set; }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入一串以逗號(,)分隔的字串，將其反向顯示：");
            string[] lists  = Console.ReadLine().Split(',');
            IEnumerable<string> LinqList = lists.Reverse();

            Console.WriteLine($"{String.Join<string>(",", LinqList)}");
            Console.ReadLine();
        }
    }
}
