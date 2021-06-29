using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample002
{
    public delegate bool MyPre(string value);
    public class MyClass
    {
      //public List<string> DoWhere(List<string> source, MyPre Pred)//04方法
        public List<string> DoWhere(List<string> source, Func<string, bool> Pred) //05方法
        {
            List<string> result = new List<string>();
            foreach (var item in source)
            {
                if (Pred.Invoke(item))
                {
                    result.Add(item);
                    Console.WriteLine(item);
                }
            }
            return result;
        }
    }

    class Program
    {
        static bool SearchDavid(string ValueBool)
        { return ValueBool == "David"; }
        static void Main(string[] args)
        {
            //建立來源資料
            List<string> Name_source = new List<string> {"Bill","John","David","Tom","David" };
            MyClass obj = new MyClass();
          //MyPre Pred = SearchDavid;02方法
          //var result = obj.DoWhere(Name_source, delegate (string x) { return x == "David"; });03方法
            var result = obj.DoWhere(Name_source, x=> { return x == "David"; });  //04方法

            foreach (var item in result)
            { Console.WriteLine(item); }
            Console.ReadLine();
        }
    }
}