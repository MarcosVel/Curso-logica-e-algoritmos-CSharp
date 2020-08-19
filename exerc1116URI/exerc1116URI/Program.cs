using System;
using System.Globalization;

namespace exerc1116URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, Y;
            double div;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);

                div = (double)X / Y;

                if (Y == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
