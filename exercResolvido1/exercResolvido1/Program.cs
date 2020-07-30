using System;
using System.Globalization;

namespace exercResolvido1
{
    class Program
    {
        static void Main(string[] args)
        {
            double larg, comp, valor, area, preco;

            Console.WriteLine("Digite a largura do terreno:");
            larg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o comprimento do terreno:");
            comp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor do metro quadrado");
            valor = double.Parse(Console.ReadLine());

            area = larg * comp;
            preco = area * valor;

            Console.WriteLine("");
            Console.WriteLine("O valor do terreno é:");
            Console.WriteLine(area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O preço do terreno é:");
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
