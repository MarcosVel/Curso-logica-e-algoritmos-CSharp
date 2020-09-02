using System;

namespace exercPropostVet02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] X;
            int pares = 0;

            N = int.Parse(Console.ReadLine());
            X = new int[N];
            string[] vet = Console.ReadLine().Split(' ');

            int cont = 0;
            for (int i = 0; i < N; i++) {
                X[i] = int.Parse(vet[i]);
                
                if (X[i] % 2 == 0) {
                    pares = X[i];
                    cont++;
                    Console.Write(pares + " ");
                }                
            }
            Console.WriteLine("");
                        
            Console.WriteLine(cont);

        }
    }
}
