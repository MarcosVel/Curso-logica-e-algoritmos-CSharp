using System;
using System.Globalization;

namespace exercResol02Sec5
{
    class Program
    {
        static void Main(string[] args)
        {            
            double idade, soma, media;
            int cont;

            idade = double.Parse(Console.ReadLine());

            soma = 0.0;
            cont = 0;
            while (idade >= 0) {
                soma += idade;
                cont += 1;
                idade = double.Parse(Console.ReadLine());
            }

            if (cont == 0) {
                Console.WriteLine("Impossivel calcular");
            }
            else {
                media = (double) soma / cont;            
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
