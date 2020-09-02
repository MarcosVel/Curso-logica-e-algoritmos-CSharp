using System;

namespace exercPropostVet03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            int[] X = new int[N];
            int[] Y = new int[N];
            int[] Z = new int[N];

            string[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                X[i] = int.Parse(vet[i]);
            }

            vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                Y[i] = int.Parse(vet[i]);
            }

            for (int i = 0; i < N; i++) {
                Z[i] = X[i] + Y[i];
                Console.Write(Z[i] + " ");
            }

        }
    }
}
