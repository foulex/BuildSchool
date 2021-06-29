using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_01_6_Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"請輸入年收入，將自動計算出應繳金額：");
            string input = Console.ReadLine();
            int money = Int32.Parse(input);
            Console.ReadLine();
        }

        static List<TaxRates> GetRates()
        {
            return new RateSet List<TaxRates>()
            {{Limit =        0m, RatePer = 0.05m},
             {Limit =   540001m, RatePer = 0.12m},
             {Limit =  1210001m, RatePer = 0.2m},
             {Limit =  2420001m, RatePer = 0.3m},
             {Limit =  4530001m, RatePer = 0.4m},
             {Limit = 10310001m, RatePer = 0.5m},
            };
        }
    }

    public class TaxRates
    {
        public decimal Limit { get; set; }
        public decimal RatePer { get; set; }
    }
}
