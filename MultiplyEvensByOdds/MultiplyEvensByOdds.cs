using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int sumOfOdds = GetSumOfOdds(number);
            int sumOfEvens = GetSumOfEvens(number);
            int result = sumOfEvens * sumOfOdds;
            Console.WriteLine(result);
        }
        public static int GetSumOfOdds(int number)
        {
            int sum = 0;
            while (number > 0) 
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0) 
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
        public static int GetSumOfEvens(int number)
        {
            int sum = 0;
            while (number > 0) 
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0) 
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
