using System;
using System.Collections.Generic;
using System.Linq;

namespace EnduranceRally
{ 

    public class EnduranceRally
    {
        static void Main()
        {
            var driversNames = Console.ReadLine().Split(' ').ToList();
            var zonesNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var checkpointIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var listOfDrivers = new List<Driver>();
            foreach (var item in driversNames)
            {
                var currentDriver = new Driver { Name = item };
                listOfDrivers.Add(currentDriver);
            }

            var resultDictionary = new Dictionary<Driver, string>();
            foreach (var driver in listOfDrivers)
            {
                var currentFuel = driver.Fuel();
                for (int i = 0; i < zonesNumbers.Count; i++) 
                {
                    if (checkpointIndexes.Contains(i)) 
                    {
                        currentFuel += zonesNumbers[i];
                    }
                    else
                    {
                        currentFuel -= zonesNumbers[i];
                    }
                    if (currentFuel <= 0) 
                    {
                        resultDictionary[driver] = $"reached {i}";
                        break;
                    }
                }
                if (currentFuel > 0) 
                {
                    resultDictionary[driver] = $"fuel left {currentFuel:F2}";
                }
            }

            foreach (var result in resultDictionary)
            {
                Console.WriteLine($"{result.Key.Name} - {result.Value}");
            }
        }
    }
}