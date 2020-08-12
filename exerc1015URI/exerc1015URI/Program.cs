using System;
using System.Globalization;

namespace exerc1015URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, dist;

            string[] num = Console.ReadLine().Split(' ');
            x1 = double.Parse(num[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(num[1], CultureInfo.InvariantCulture);

            num = Console.ReadLine().Split(' ');
            x2 = double.Parse(num[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(num[1], CultureInfo.InvariantCulture);

            dist = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(dist.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
