using System;

namespace exercPropost01Matriz
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
                        
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if (matriz[i, j] < 0) {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }


        }
    }
}
