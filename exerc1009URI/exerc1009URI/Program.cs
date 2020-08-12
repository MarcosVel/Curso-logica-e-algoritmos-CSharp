using System;
using System.Globalization;

namespace exerc1009URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salFixo, totalVendas, receber;

            nome = Console.ReadLine();
            salFixo = double.Parse(Console.ReadLine());
            totalVendas = double.Parse(Console.ReadLine());

            receber = salFixo + totalVendas * 15.0 / 100;

            Console.WriteLine("TOTAL = R$ " + receber.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
