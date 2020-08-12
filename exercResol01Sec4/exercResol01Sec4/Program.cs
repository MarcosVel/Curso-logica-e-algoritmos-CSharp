using System;
using System.Globalization;

namespace exercResol01Sec4
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, final;

            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());

            final = (double) nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + final.ToString("F1", CultureInfo.InvariantCulture));

            if (final < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }

        }
    }
}
