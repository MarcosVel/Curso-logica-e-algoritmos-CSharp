using System;
using System.Globalization;

namespace exercResol02Sec4
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta, R1, R2;

            string[] num = Console.ReadLine().Split(' ');
            A = double.Parse(num[0]);
            B = double.Parse(num[1]);
            C = double.Parse(num[2]);

            
            delta = Math.Pow(B, 2.0) - (4 * A * C);

            if (A == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                R1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                R2 = (-B - Math.Sqrt(delta)) / (2.0 * A);
                Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));

            }           

        }
    }
}
