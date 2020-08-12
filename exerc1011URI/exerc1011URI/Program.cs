using System;
using System.Globalization;

namespace exerc1011URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, vol, pi = 3.14159;

            R = double.Parse(Console.ReadLine());

            vol = (double)(4 / 3.0) * pi * Math.Pow(R, 3.0);

            Console.WriteLine("VOLUME = " + vol.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
