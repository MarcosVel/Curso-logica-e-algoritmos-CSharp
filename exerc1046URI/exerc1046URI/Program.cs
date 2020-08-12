using System;

namespace exerc1046URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrInic, hrFinal, duracao;

            string[] vet = Console.ReadLine().Split(' ');
            hrInic = int.Parse(vet[0]);
            hrFinal = int.Parse(vet[1]);

            if (hrInic < hrFinal)
            {
                duracao = hrFinal - hrInic;
            } 
            else
            {
                duracao = 24 - hrInic + hrFinal;
            }             

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
