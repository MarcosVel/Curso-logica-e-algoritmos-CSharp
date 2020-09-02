using System;
using System.Globalization;

namespace exercPropostVet04
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] X = new double[N];
            double soma = 0.0, media;

            string[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                X[i] = double.Parse(vet[i]);
                soma += X[i];                
            }

            Console.WriteLine("");

            media = (double)soma / N;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++) {                
                if (X[i] < media) {                    
                    Console.WriteLine(X[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            Console.ReadLine();

        }
    }
}
