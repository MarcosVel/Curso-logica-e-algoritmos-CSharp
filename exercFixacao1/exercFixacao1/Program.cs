using System;
using System.Globalization;

namespace exercFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");            
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com nome do seu pai, sua idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string pai = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine("");
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(pai);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

        }
    }
}
