using System;
using System.Globalization;

namespace exercPropostVet05
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, N = int.Parse(Console.ReadLine());
            int[] X;
            double media;

            X = new int[N];
            string[] vet = Console.ReadLine().Split(' ');

            int cont = 0;
            for (int i = 0; i < N; i++) {
                X[i] = int.Parse(vet[i]);
                if (X[i] % 2 == 0) {
                    soma += X[i];
                    cont++;
                }                
            }

            media = (double) soma / cont;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
