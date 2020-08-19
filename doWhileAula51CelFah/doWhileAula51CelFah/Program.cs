using System;
using System.Globalization;

namespace doWhileAula51CelFah
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char repetir;

            do {
                Console.Write("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                F = (double)C * 9.0 / 5.0 + 32.0;

                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));

                Console.Write("Deseja repetir (s/n)? ");
                repetir = char.Parse(Console.ReadLine());

            } while (repetir == 's');            

        }
    }
}
