using System;
using System.Globalization;

namespace exercResol02Sec6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] X;
            double soma = 0.0, media;

            N = int.Parse(Console.ReadLine());
            X = new double[N];
            string[] vet = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++) {
                X[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }

            for(int i = 0; i < N; i++) {
                Console.Write(vet[i] + " ");
            }
            Console.WriteLine(); //para quebrar a linha no final do vetor

            for(int i = 0; i < N; i++) {
                soma += X[i];                
            }

            media = soma / N;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));            

        }
    }
}
