using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class SalesReport
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dictOfTowns = new SortedDictionary<string, double>();
            var listOfSales = new List<Sale>();
            for (int i = 0; i < n; i++)
            {
                var currentSale = ReadSale();
                listOfSales.Add(currentSale);
            }
            var salesByTown = new SortedDictionary<string, decimal>();
            for (int i = 0; i < listOfSales.Count; i++)
            {
                var currentSale = listOfSales[i];
                if (salesByTown.ContainsKey(currentSale.Town)) 
                {
                    salesByTown[currentSale.Town] += currentSale.Price * currentSale.Quantity;
                }
                else
                {
                    salesByTown[currentSale.Town] = currentSale.Price * currentSale.Quantity;
                }
            }

            foreach (var item in salesByTown)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }

        public static Sale ReadSale()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var inputSale = new Sale
            {
                Town = input[0],
                Product = input[1],
                Price = decimal.Parse(input[2]),
                Quantity = decimal.Parse(input[3])
            };
            return inputSale;
        }
    }
}
