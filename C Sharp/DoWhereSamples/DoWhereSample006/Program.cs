using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhereSample006
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> source1 = new List<string> { "Bill", "John", "David", "Tom", "David" };
            var result1 = source1.DoWhere(new SearchDavid());
            Display(result1);

            List<int> source2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result2 = source2.DoWhere(new SearchMoreThen3());
            Display(result2);

            Console.ReadLine();
        }

        static void Display<T>(IEnumerable<T> source)
        {
            foreach(var item in source)
            {
                Console.WriteLine(item);
            }
        }
    }
    public interface IPrediCATe<TTT>
    {
        bool InvokeAAA(TTT item);
    }
    public static class MyClass
    {
        public static IEnumerable<XDDD> DoWhere<XDDD>(this IEnumerable<XDDD> source, IPrediCATe<XDDD> predicate)
        {
            foreach(var foritem in source)
            {
                if (predicate.InvokeAAA(foritem))
                {
                    yield return foritem;
                }
            }
        }
    }
    public class SearchDavid : IPrediCATe<string>
    {
        public bool Invoke(string x)
        {
            return x == "David";
        }

        public bool InvokeAAA(string item)
        {
            throw new NotImplementedException();
        }
    }

    public class SearchMoreThen3 : IPrediCATe<int>
    {
        public bool Invoke(int x)
        {
            return x > 3;
        }

        public bool InvokeAAA(int item)
        {
            throw new NotImplementedException();
        }
    }
}
