using System;
using System.Globalization;

namespace exercPropostVet08
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] altura = new double[N];
            char[] sexo = new char[N];

            //para leitura no console
            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(vet[0]);
                sexo[i] = char.Parse(vet[1]);
            }

            //menor E maior altura
            double menorAlt = altura[0];            
            double maiorAlt = altura[0];
            for (int i = 0; i < N; i++) {
                //menor altura
                if (altura[i] < menorAlt) {
                    menorAlt = altura[i];
                }
                //maior altura
                else if (altura[i] > maiorAlt) {
                maiorAlt = altura[i];
                }
            }          
            
            //media das alturas das mulheres
            double media = 0.0;
            double soma = 0.0;
            int quantF = 0;
            for (int i = 0; i < N; i++) {
                if (sexo[i] == 'F') {
                    quantF++;
                    soma += altura[i];
                    media = (double)soma / quantF;
                }
            }

            //numero de homens
            int numHomens = 0;
            for (int i = 0; i < N; i++) {
                if (sexo[i] == 'M') {
                    numHomens++;
                }
            }

            Console.WriteLine("Menor altura = " + menorAlt.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maiorAlt.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + numHomens);

        }
    }
}
