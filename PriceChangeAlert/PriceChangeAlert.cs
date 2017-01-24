using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorPriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            double significanceLimit = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());
            for (int i = 0; i < number - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double difference = percentage(lastPrice, currentPrice);
                bool isSignificantDifference = hasDifference(difference, significanceLimit);
                string message = GetResult(currentPrice, lastPrice, difference, isSignificantDifference);
                Console.WriteLine(message);
                lastPrice = currentPrice;
            }
        }

        private static string GetResult(double currentPrice, double lastPrice, double difference, bool eitherTrueOrFalse)
        {
            string format = "";
            if (difference == 0)
            {
                format = string.Format("NO CHANGE: {0}", currentPrice);
                return format;
            }
            else if (!eitherTrueOrFalse)
            {
                format = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
                return format;
            }
            else if (eitherTrueOrFalse && (difference > 0))
            {
                format = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
                return format;
            }
            else if (eitherTrueOrFalse && (difference < 0))
            {
                format = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
                return format;
            }
            return format;
        }

        private static bool hasDifference(double significanceLimit, double isDifference)
        {
            if (Math.Abs(significanceLimit) >= isDifference)
            {
                return true;
            }
            return false;
        }

        private static double percentage(double lastPrice, double currentPrice)
        {
            double difference = (currentPrice - lastPrice) / lastPrice;
            return difference ;
        }
    }
}


