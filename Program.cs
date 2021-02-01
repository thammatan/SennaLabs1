using System;
using System.Collections.Generic;

namespace SennaLabs1 {
    class Product {
        public double cost_price { get; set; }
        public double sell_price { get; set; }
        public int inventory { get; set; }
    }
    class Program {
        static void Main(string[] args) {
            var profit = new Dictionary<string, Product>()
         {
            { "A", new Product { cost_price=32.67, sell_price=45.00, inventory=1200 } },
            { "B", new Product { cost_price=225.89, sell_price=550.00, inventory=100 } },
        };
            foreach (var pair in profit) {
                Console.WriteLine("{0} : {1}", pair.Key, ((pair.Value.sell_price - pair.Value.cost_price) * pair.Value.inventory).ToString("N0"));
            }
        }
    }
}
