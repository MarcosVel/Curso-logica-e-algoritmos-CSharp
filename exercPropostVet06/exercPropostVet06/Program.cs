using System;

namespace exercPropostVet06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());            

            string[] nomes = new string[N];
            int[] idades = new int[N];
                        
            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                nomes[i] = vet[0];
                idades[i] = int.Parse(vet[1]);                                
            }

            int maisVelho = idades[0];
            int posicao = 0;
            for (int i = 0; i < N; i++) {
                if (idades[i] > maisVelho) {
                    maisVelho = idades[i];
                    posicao = i;                    
                }                
            }

            Console.WriteLine("Pessoa mais velha: " + nomes[posicao]);

        }
    }
}
