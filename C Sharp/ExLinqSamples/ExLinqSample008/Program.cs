using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample008
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            //D4_08
            var result = list.GroupBy(x => x.City);
            foreach(var item in result)
            {
                Console.WriteLine($"住在{item.Key}的有：");
                foreach(var p in item)
                {
                    Console.WriteLine($"{p.Name}");
                }
                Console.WriteLine("----------");
            }
            Console.ReadLine();
            //-----------------------------------------------------------
            //D4_09

            var result09 =
                from osso in list
                group osso by osso.City into gXp
                select gXp;

            foreach(var item in result09)
            {
                Console.WriteLine($"住在{item.Key}的人有：");
                foreach(var p in item)
                {
                    Console.WriteLine(p.Name);
                }
                Console.WriteLine("----------");
            }
            Console.ReadLine();
            //-----------------------------------------------------------
        }

        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData(){Name="Bill",City="台北"},
                new MyData(){Name="John",City="台北"},
                new MyData(){Name="Tom",City="高雄"},
                new MyData(){Name="David",City="台南"},
                new MyData(){Name="Jeff",City="台南"},
            };
        }
    }
    class MyData
    {
        public string City { get; set; } 
        public string Name { get; set; }
    }
}
