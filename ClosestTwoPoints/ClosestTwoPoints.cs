using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var listOfPoints = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var currentCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                Point currentPoint = new Point
                {
                    x = currentCoordinates[0],
                    y = currentCoordinates[1]
                };
                listOfPoints.Add(currentPoint);
            }
            var resultList = FindClosestPoints(listOfPoints);
            var firstResultPoint = new Point();
            firstResultPoint = resultList[0];
            var secondResultPoint = new Point();
            secondResultPoint = resultList[1];
            var resultDistance = CalculateDistance(firstResultPoint, secondResultPoint);

            Console.WriteLine($"{resultDistance:F3}");
            Console.WriteLine($"({firstResultPoint.x}, {firstResultPoint.y})");
            Console.WriteLine($"({secondResultPoint.x}, {secondResultPoint.y})");
        }

        public static List<Point> FindClosestPoints(List<Point> listOfPoints)
        {
            var resultList = new List<Point>();
            double closestDistance = double.MaxValue;
            for (int i = 0; i < listOfPoints.Count; i++)
            {
                for (int j = i + 1; j < listOfPoints.Count; j++) 
                {
                    double distance = CalculateDistance(listOfPoints[i], listOfPoints[j]);
                    if (distance < closestDistance) 
                    {
                        closestDistance = distance;
                        resultList = new List<Point> { listOfPoints[i], listOfPoints[j] };
                    }
                }
            }
            return resultList;
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            var sideA = Math.Abs(p1.x - p2.x);
            var sideB = Math.Abs(p1.y - p2.y);
            var distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return distance;
        }
    }
}
