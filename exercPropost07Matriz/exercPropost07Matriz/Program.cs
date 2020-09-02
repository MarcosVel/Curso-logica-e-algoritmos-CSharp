using System;
using System.Globalization;

namespace exercPropost07Matriz {
    class Program {
        static void Main(string[] args) {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[M, N];

            for (int i = 0; i < M; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }

            int filaGirar = int.Parse(Console.ReadLine());

            filaGirar -= 1;

            int ultimoFila = matriz[filaGirar, N - 1];

            for (int j = N - 1; j > 0; j--) {
                matriz[filaGirar, j] = matriz[filaGirar, j - 1];
            }

            matriz[filaGirar, 0] = ultimoFila;

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
