using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();

            //D4_01
            //計算list中的總和
            int total = list.Sum(x => x.Age);
            Console.WriteLine($"年齡總和為{total}歲");

            //取得list中Age最小值
            var minage = list.Min(x => x.Age);
            Console.WriteLine($"最小年齡為{minage}歲");

            //取得list中Age最大值
            var maxage = list.Max(x => x.Age);
            Console.WriteLine($"最大年齡為{maxage}歲");

            //取得list中的數量
            //Count與Count()是不同的
            int count = list.Count();
            Console.WriteLine($"list中的總個數有{count}個");

            int countOfBill = list.Count(x => x.Name == "Bill");
            Console.WriteLine($"list裡面有{countOfBill}個Bill");

            //取得list中的平均值
            var average = list.Average(x => x.Age);
            Console.WriteLine($"list中的年齡平均值為{average}歲");

            //--------------------------------------------------------------
            Console.ReadLine();

            //D4_02
            //找出名稱為Bill中的Age最小值
            var Billmin = list.Where(x => x.Name == "Bill").Min(x => x.Age);
            Console.WriteLine($"名為Bill的人之中年齡最小的是{Billmin}歲");

            //計算名稱為Bill的年齡總和
            var BillSum = list.Where(x => x.Name == "Bill").Sum(x => x.Age);
            Console.WriteLine($"Bill們的年齡總和為{BillSum}歲");

            //計算名稱為Bill的年齡平均
            var BillAverage = list.Where(x => x.Name == "Bill").Average(x => x.Age);
            Console.WriteLine($"Bill們的平均年齡為{BillAverage}歲");

            //--------------------------------------------------------------
            Console.ReadLine();
        }

        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData() { Name = "Bill", Age = 47 },
                new MyData() { Name = "John", Age = 37 },
                new MyData() { Name = "Tom", Age = 48 },
                new MyData() { Name = "David", Age = 36 },
                new MyData() { Name = "Bill", Age = 35 },
            };

        }

    }
    class MyData
    {
        public string   Name    { get; set; }
        public int      Age     { get; set; }
    }
}
