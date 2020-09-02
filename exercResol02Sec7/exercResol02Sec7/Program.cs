using System;
using System.Globalization;

namespace exercResol02Sec7
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] matriz;

            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            matriz = new int[M, N];

            for (int i = 0; i < M; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            int[] vet = new int[M];

            for (int i = 0; i < M; i++) {
                int soma = 0;
                for (int j=0; j<N; j++) {
                    soma += matriz[i, j];
                }
                vet[i] = soma;
            }

            for (int i = 0; i < M; i++) {
                Console.WriteLine(vet[i]);
            }
            

        }
    }
}
