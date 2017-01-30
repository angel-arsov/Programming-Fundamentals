using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class SumArrays
    {
        static void Main()
        {
            //Reading the first array
            string firstNumbers = Console.ReadLine();
            string[] firstItems = firstNumbers.Split(' ');
            int[] firstArray = new int[firstItems.Length];
            for (int i = 0; i < firstItems.Length; i++)
            {
                firstArray[i] = int.Parse(firstItems[i]);
            }

            //Reading the second array
            string secondNumbers = Console.ReadLine();
            string[] secondItems = secondNumbers.Split(' ');
            int[] secondArray = new int[secondItems.Length];
            for (int i = 0; i < secondItems.Length; i++)
            {
                secondArray[i] = int.Parse(secondItems[i]);
            }

            //Creating the result array
            int resultArrayLength = Math.Max(firstItems.Length, secondItems.Length);
            int[] resultArray = new int[resultArrayLength];
            for (int i = 0; i < resultArrayLength; i++)
            {
                resultArray[i] = (firstArray[i % firstItems.Length] + secondArray[i % secondItems.Length]);
            }
            for (int i = 0; i < resultArrayLength; i++)
            {
                Console.Write($"{resultArray[i].ToString()} ");
            }
            Console.WriteLine();
        }
    }
}
