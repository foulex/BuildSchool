using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Zodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new string[] { "牛", "豬", "羊", "兔", "虎", "馬", "龍", "鼠" };
            List<string> Answer = new List<string> { "鼠", "牛", "虎", "兔", "龍", "蛇", "馬", "羊", "猴", "雞", "狗", "豬" };

            var result = array.OrderBy(x=>x, new Zcomparer(Answer));
            Console.WriteLine(string.Join(",", result));

            Console.ReadLine();
        }
    }

    internal class Zcomparer : IComparer<string>
    {
        public List<string> Ans { get; }
        public Zcomparer(List<string> answer)
        { Ans = answer; }
        public int Compare(string x, string y)
        {
            return Ans.IndexOf(x) - Ans.IndexOf(y);
        }
    }
}