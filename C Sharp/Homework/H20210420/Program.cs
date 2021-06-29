using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H20210420
{
    public class Product
    {
        public DateTime InDay { get; set; }
        public int Quantity { get; set; }
    }
    class Program
    {
        /*算出與前一天的差距*/
        static void Main(string[] args)
        {
            var list = new List<Product>
            {
                new Product{InDay = new DateTime(2021, 1, 1), Quantity = 10},
                new Product{InDay = new DateTime(2021, 1, 2), Quantity = 30},
                new Product{InDay = new DateTime(2021, 1, 3), Quantity = 30},
                new Product{InDay = new DateTime(2021, 1, 4), Quantity = 50},
                new Product{InDay = new DateTime(2021, 1, 5), Quantity = 100},
            };
            //　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　
            //我的作法↓
            for (int i = 0; i <= list.Count()-1; i++)
            {
                Console.Write($"{list[i].InDay:yyyy/MM/dd}　－　");
                Console.WriteLine($"{list[i].Quantity-list[(i-1)<0?0:i-1].Quantity}");
            }
            //Console.WriteLine(string.Join(Environment.NewLine,$"{list}"));

            //　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　
            //foreach做法↓
            List<Product> products = new List<Product>();
            int lastQuantity = 0;
            foreach(var p in list)
            {
                products.Add(new Product { InDay = p.InDay, Quantity = p.Quantity - lastQuantity });
                lastQuantity = p.Quantity;
            }
            //Console.WriteLine(string.Join(Environment.NewLine,$"{products.Select(x=>x.InDay.ToString("yyyy/MM/dd"))}"));

            //　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　
            //linq寫法↓
            int q = 0;
            var r = list.Select(x => 
            {
                var result = new Product { InDay = x.InDay, Quantity = x.Quantity - q };
                q = x.Quantity;
                return result;
            });
            //　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　
            //index寫法↓
            var r3 = Enumerable.Range(0, list.Count).Select(x=> new Product 
                        { InDay = list[x].InDay,Quantity = list[x].Quantity -  (x > 0 ? list[x].Quantity : 0) });

            //　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　
            Console.ReadLine();
        }
    }

}
