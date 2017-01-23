using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long totalPhotos = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());
            double filtering = (totalPhotos * (filterFactor / 100));
            long filteredPhotos = (long)Math.Ceiling(filtering);
            filterTime *= totalPhotos;
            uploadTime *= filteredPhotos;
            long totalSeconds = (filterTime + uploadTime);
            TimeSpan totalTime = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine(totalTime.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
