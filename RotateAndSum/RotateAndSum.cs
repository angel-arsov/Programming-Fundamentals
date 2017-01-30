using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            string[] items = numbers.Split(' ');
            int[] arrayNumbers = new int[items.Length];
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = int.Parse(items[i]);
            }

            int rotatingTimes = int.Parse(Console.ReadLine());
            int[] sumArray = new int[arrayNumbers.Length];
            int[] rotatedArray = new int[arrayNumbers.Length];
            int[] resultArray = new int[sumArray.Length];

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = arrayNumbers[i];
            }
            for (int r = 1; r <= rotatingTimes; r++) 
            {
                for (int i = 1; i < arrayNumbers.Length; i++) 
                {
                    rotatedArray[i] = sumArray[i - 1];
                }
                rotatedArray[0] = sumArray[rotatedArray.Length - 1];

                if (rotatingTimes > 1) 
                {
                    for (int i = 0; i < sumArray.Length; i++)
                    {
                        resultArray[i] +=rotatedArray[i];
                    }
                }
                else if (rotatingTimes == 1) 
                {
                    for (int i = 0; i < sumArray.Length; i++)
                    {
                        resultArray[i] = rotatedArray[i];
                    }
                }

                for (int j = 0; j < sumArray.Length; j++)
                {
                    sumArray[j] = rotatedArray[j];
                }
            }

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write(resultArray[i].ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
