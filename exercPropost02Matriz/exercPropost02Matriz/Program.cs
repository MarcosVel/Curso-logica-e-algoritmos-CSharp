using System;

namespace exercPropost02Matriz {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            int[,] matriz;

            matriz = new int[N, N];

            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }

            int[] s = new int[N];
            
            for(int i = 0; i < N; i++) {
                int soma = 0;
                for (int j = 0; j < N; j++) {
                    soma += matriz[i, j];
                }
                s[i] = soma;

                Console.WriteLine(s[i]);
            }
             
        }
    }
}
