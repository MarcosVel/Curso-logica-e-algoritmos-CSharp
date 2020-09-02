using System;

namespace exercPropostVet07
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            string[] nomes = new string[N];
            double[] primSem = new double[N];
            double[] segSem = new double[N];

            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                nomes[i] = vet[0];
                primSem[i] = double.Parse(vet[1]);
                segSem[i] = double.Parse(vet[2]);
            }

            double media;

            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < N; i++) {
                media = (double)(primSem[i] + segSem[i]) / 2;
                if (media >= 6) {
                    Console.WriteLine(nomes[i]);
                }
            }

        }
    }
}
