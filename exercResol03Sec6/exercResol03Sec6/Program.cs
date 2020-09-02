using System;
using System.Globalization;

namespace exercResol03Sec6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;            
            
            N = int.Parse(Console.ReadLine());
            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];
            
            //leitura dos dados
            for (int i = 0; i < N; i++) {
                string[] dados = Console.ReadLine().Split(' ');
                nomes[i] = dados[0];
                idades[i] = int.Parse(dados[1]);
                alturas[i] = double.Parse(dados[2]);
            }

            //calculo da altura media
            double somaAlt = 0.0;
            for (int i = 0; i < N; i++) {
                somaAlt += alturas[i];
            }
            double mediaAlt = somaAlt / N;
            Console.WriteLine("Altura média: " + mediaAlt.ToString("F2"));

            //porcentagem da idade < 16
            int cont = 0;
            for (int i = 0; i < N; i++) {
                if (idades[i] < 16) {
                    cont++;
                }
            }
            double porcentagem = (double)cont / N * 100;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");

        }
    }
}
