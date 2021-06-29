using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample001
{
    class MyData
    {
        public string   Name    { get; set; }
        public int      Age     { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //課程002
            var QList = CreateList();
            var XP = QList.Where((x) => x.Name == "Bill");
            //var XP = Enumerable.Where(QList,(x)=> x.Name =="Bill");

            //----------------------------------------------------------------------------------
            Console.WriteLine("課程003");
            var Nums1 = 37;
            var person1 = XP.FirstOrDefault((x) => x.Age < Nums1);
            Console.WriteLine($"小於 {Nums1} 歲的人第一個被找到的是 : {person1.Name}。");
            Console.ReadLine();
            // 因為找不到, 就會跳出例外
            var Nums2 = 30;
            var person2 = XP.First((x) => x.Age < Nums2);
            Console.WriteLine($"小於 {Nums2} 歲的人第一個被找到的是 : {person2.Name}。");
            Console.ReadLine();
            //----------------------------------------------------------------------------------
            Console.WriteLine("課程004");
            var Nums04_1 = 35;
            var person04_1 = XP.LastOrDefault((x) => x.Age > Nums04_1);
            Console.WriteLine($"大於 {Nums04_1} 歲的人最後一個被找到的是 : {person04_1.Name}。");
            Console.ReadLine();
            // 因為找不到, 就會跳出例外
            var Nums04_2 = 50;
            var person04_2 = XP.Last((x) => x.Age > Nums04_2);
            Console.WriteLine($"大於 {Nums04_2} 歲的人最後一個被找到的是 : {person04_2.Name}。");
            Console.ReadLine();
            //----------------------------------------------------------------------------------
            Console.WriteLine("課程005");
            var person05_1 = XP.SingleOrDefault((x) => x.Name =="Tom");
            Console.WriteLine($"找到唯一的人 : {person05_1.Name}，他為{person05_1.Age}歲。");
            Console.ReadLine();
            // 因為有重複, 就會跳出例外
            var person05_2 = XP.Single((x) => x.Name =="Bill");
            Console.WriteLine($"找到唯一的人 : {person05_2.Name}，他為{person05_2.Age}歲。");
            Console.ReadLine();
            //----------------------------------------------------------------------------------
            Console.WriteLine("課程006");
            var person = QList.FirstOrDefault((x) => x.Name == "李小龍");
            if(person== null)
            {
                Console.WriteLine("查無此人。");
            }
            //處理null的方法
            //----------------------------------------------------------------------------------
            Console.WriteLine("課程007");
            int N07_index = 1;
            var list07 = CreateList();
            //這裡的person07為單個物件，也就是Mydata person07
            var person07 = list07.ElementAtOrDefault(N07_index);
            if (person07 == null)
            {
                Console.WriteLine("查無此人。");
            }
            else
            {
                Console.WriteLine($"找到索引為{N07_index}的人為{person07.Name}，為{person07.Age}歲。");
            }
            Console.ReadLine();
            //----------------------------------------------------------------------------------
            Console.WriteLine("課程008");
            var list08 = CreateList();
            string name08 = "David";
            bool result08 = list08.Any(x => x.Name == name08);
            if (result08)
            {
                Console.WriteLine($"找到{name08}");
            }
            else
            {
                Console.WriteLine($"找不到{name08}");
            }
            Console.ReadLine();
            //----------------------------------------------------------------------------------
            Console.WriteLine("課程009");
            var list09 = CreateList();
            string name09 = "Bill";
            int Age09 = 40;
            bool IsAllBill = list09.All(x => x.Name == name09);
            if (IsAllBill)
            {
                Console.WriteLine($"全都是{name09}");
            }
            else
            {
                Console.WriteLine($"有些人不叫{name09}");
            }
            bool IsAllOverFourty = list09.All(x => x.Age >= Age09);
            if (IsAllOverFourty)
            {
                Console.WriteLine($"全部的人都大於{Age09}歲。");
            }
            else
            {
                Console.WriteLine($"有些人小於{Age09}歲。");
            }
            Console.ReadLine();

            List<MyData> XList = CreateList();

            //Query Expression
            IEnumerable<MyData> people =
                from    Xdata in XList
                where   Xdata.Name == "Bill"
                select  Xdata;

            Console.WriteLine("課程001");
            foreach(MyData Xperson in people)
            {
                Console.WriteLine($"{Xperson.Name}是{Xperson.Age}歲。");
            }
            Console.ReadLine();
        }
        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData{Name= "Bill"     , Age=47 },
                new MyData{Name= "John"     , Age=37 },
                new MyData{Name= "Tom"      , Age=48 },
                new MyData{Name= "David"    , Age=36 },
                new MyData{Name= "Bill"     , Age=35 },
            };
        }
    }
}
