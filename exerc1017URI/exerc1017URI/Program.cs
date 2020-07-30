using System;
using System.Globalization;

namespace exerc1017URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrs, kmh, dist, autonomia = 17;
            double litrosNec;

            Console.WriteLine("SAIBA QUANTOS LITROS PRECISARÁ EM SUA VIAGEM");
            Console.WriteLine("");

            Console.Write("Digite quantas horas irá gastar: ");
            hrs = int.Parse(Console.ReadLine());
            Console.Write("Digite quantos km irá percorrer: ");
            kmh = int.Parse(Console.ReadLine());

            dist = kmh * hrs;
            litrosNec = (double) dist / autonomia;

            Console.WriteLine("");
            Console.WriteLine("Litros necessários: " + litrosNec.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
