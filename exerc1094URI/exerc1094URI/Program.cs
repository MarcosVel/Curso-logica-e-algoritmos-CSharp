using System;
using System.Globalization;

namespace exerc1094URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()),
                qtdCoelho = 0,
                qtdRato = 0,
                qtdSapo = 0,
                qtdAnimais = 0;
            char Tipo;
            double pctCoelho = 0.0,
                pctRato = 0.0,
                pctSapo = 0.0;

            for (int i = 1; i <= N ; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                int Quantia = int.Parse(vet[0]);
                Tipo = char.Parse(vet[1]);
                if (Tipo == 'C') {
                    qtdCoelho += Quantia;                    
                } else if (Tipo == 'R') {
                    qtdRato += Quantia;
                } else {
                    qtdSapo += Quantia;
                }
                qtdAnimais = qtdCoelho + qtdRato + qtdSapo;

                pctCoelho = (double)qtdCoelho / qtdAnimais * 100;
                pctRato = (double)qtdRato / qtdAnimais * 100;
                pctSapo = (double)qtdSapo / qtdAnimais * 100;
            }
            
            Console.WriteLine("Total: " + qtdAnimais + " cobaias");
            Console.WriteLine("Total de coelhos: " + qtdCoelho);
            Console.WriteLine("Total de ratos: " + qtdRato);
            Console.WriteLine("Total de sapos: " + qtdSapo);
            Console.WriteLine("Percentual de coelhos: " + pctCoelho.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + pctRato.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + pctSapo.ToString("F2", CultureInfo.InvariantCulture) + " %");

        }
    }
}
