using System;

namespace exerc1050URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int DDD;

            DDD = int.Parse(Console.ReadLine());
            string localizacao;

            switch(DDD)
            {
                case 61:
                    localizacao = "Brasilia";
                    break;
                case 71:
                    localizacao = "Salvador";
                    break;
                case 11:
                    localizacao = "Sao Paulo";
                    break;
                case 21:
                    localizacao = "Rio de Janeiro";
                    break;
                case 32:
                    localizacao = "Juiz de Fora";
                    break;
                case 19:
                    localizacao = "Campinas";
                    break;
                case 27:
                    localizacao = "Vitoria";
                    break;
                case 31:
                    localizacao = "Belo Horizonte";
                    break;
                default:
                    localizacao = "DDD nao cadastrado";
                    break;
            }

            Console.WriteLine(localizacao);

        }
    }
}
