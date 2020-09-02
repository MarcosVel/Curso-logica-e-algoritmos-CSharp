using System;
using System.Globalization;

namespace exercResol01Sec7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matriz;

            matriz = new int[N, N];

            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++) {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();

            int negativos = 0;
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (matriz[i, j] < 0) {
                        negativos++;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + negativos);

        }
    }
}
