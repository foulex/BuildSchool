using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhereSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> source1 = new List<string> { "Bill", "John", "David", "Tom", "David" };
          //var obj = new MyClass();
          //轉入 List<string>, Func<string, bool>
            source1.DoWhere( x => x != "David").Display();

          //↓實際上是這樣
          //Func<string, bool> func = new Func<string, bool>(search);
          //var result = obj.DoWhere(source, func);

            List<int> source2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            source2.DoWhere(x => x > 3).Display();
            //source2.Display();

            Console.ReadLine();
        }
    }
    public static class MyClass
    {
        public static IEnumerable<T> DoWhere<T> (this IEnumerable<T> source, Func<T,bool> predicateIT)
        {
            //List<T> result = new List<T>();
            foreach(var item in source)
            {
                if (predicateIT.Invoke(item))
                {  yield return item; }
            }
            //return result;
        }
        public static void Display<T> (this IEnumerable<T> source)
        {
            foreach(var item in source)
            { Console.WriteLine(item); }
        }
    }
}
