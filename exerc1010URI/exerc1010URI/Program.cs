using System;
using System.Globalization;

namespace exerc1010URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int peca1, qtdPeca1, peca2, qtdPeca2;
            double valorPeca1, valorPeca2, total;

            string[] valores = Console.ReadLine().Split(' ');
            peca1 = int.Parse(valores[0]);
            qtdPeca1 = int.Parse(valores[1]);
            valorPeca1 = double.Parse(valores[2]);

            valores = Console.ReadLine().Split(' ');
            peca2 = int.Parse(valores[0]);
            qtdPeca2 = int.Parse(valores[1]);
            valorPeca2 = double.Parse(valores[2]);

            total = qtdPeca1 * valorPeca1 + qtdPeca2 * valorPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
