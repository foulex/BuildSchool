using ExtensionSample001.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> source = new List<string> { "Bill", "John", "David", "Tom", "Daveid" };
            var result = source.DoWhere<string>(x => x == "David");
          //原本應該這樣寫
          //var result = MyClass.DoWhere(source, (x=> x == "David" ));
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

          //修改成List<T>後，什麼型別都適用，但不能用在return，因為不能確定return出什麼
            List<int> source2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result2 = source2.DoWhere(x => x > 3);
            foreach(var item in result2)//↑這邊的DoWhere自動依照傳入的參數型別判斷
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
