using System;
using System.Globalization;

namespace exercPropostVet09
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
                        
            string[] nomes = new string[N];
            double[] precoCompra = new double[N];
            double[] precoVenda = new double [N];

            //ENTRADA
            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                nomes[i] = vet[0];
                precoCompra[i] = double.Parse(vet[1]);
                precoVenda[i] = double.Parse(vet[2]);
            }

            //lucros %      
            int menorDez = 0;
            int entreDezVinte = 0;
            int acimaVinte = 0;            
            for (int i = 0; i < N; i++) {
                double lucro = precoVenda[i] - precoCompra[i];
                double margemLucro = (lucro / precoCompra[i]) * 100;
                if (margemLucro < 10) {
                    menorDez++;                    
                }
                else if (margemLucro <= 20) {
                    entreDezVinte++;
                }
                else {
                    acimaVinte++;
                }
            }

            //totais
            double totalCompra = 0.0;
            double totalVenda = 0.0;
            double lucroTotal = 0.0;
            for (int i = 0; i < N; i++) {
                totalCompra += precoCompra[i];
                totalVenda += precoVenda[i];
                lucroTotal = totalVenda - totalCompra;
            }

            //SAÍDA
            Console.WriteLine("Lucro abaixo de 10%: " + menorDez);
            Console.WriteLine("Lucro entre 10% e 20%: " + entreDezVinte);
            Console.WriteLine("Lucro acima de 20%: " + acimaVinte);
            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
