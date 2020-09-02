using System;

namespace exercPropostVet01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] X;
                       
            N = int.Parse(Console.ReadLine());
            X = new double[N];
            string[] vet = Console.ReadLine().Split(' ');

            int cont = 0;
            for (int i = 0; i < N; i++) {
                X[i] = double.Parse(vet[i]);
                cont++;
            }

            double maiorNum = 0.0;
            for (int i = 0; i < N; i++) {
                if (maiorNum < X[i]) {
                    maiorNum = X[i];
                    cont = i;
                }
            }

            Console.WriteLine(maiorNum);
            Console.WriteLine(cont);
                        
        }
    }
}
