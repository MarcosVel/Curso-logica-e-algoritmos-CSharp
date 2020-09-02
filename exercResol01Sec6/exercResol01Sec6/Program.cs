using System;

namespace exercResol01Sec6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] A;

            N = int.Parse(Console.ReadLine());
            A = new int[N];

            string[] linha = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                A[i] = int.Parse(linha[i]);                
            }

            for (int i = 0; i < N; i++) {
                if (A[i] < 0) {
                    Console.WriteLine(linha[i]);
                }
            }

        }
    }
}
