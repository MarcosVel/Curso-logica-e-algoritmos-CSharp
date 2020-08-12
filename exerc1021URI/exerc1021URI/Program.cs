using System;
using System.Globalization;

namespace exerc1021URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            int notas, moedas, sobra, quociente;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            sobra = (int)(N * 100.0 + 0.5);
            Console.WriteLine("NOTAS:");

            notas = 100;
            quociente = sobra / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            sobra = sobra % (notas * 100);

            notas = 50;
            quociente = sobra / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            sobra = sobra % (notas * 100);

            notas = 20;
            quociente = sobra / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            sobra = sobra % (notas * 100);

            notas = 10;
            quociente = sobra / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            sobra = sobra % (notas * 100);

            notas = 5;
            quociente = sobra / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            sobra = sobra % (notas * 100);

            notas = 2;
            quociente = sobra / (notas * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + notas + ".00");
            sobra = sobra % (notas * 100);

            // MOEDAS

            Console.WriteLine("MOEDAS:");

            moedas = 100;
            quociente = sobra / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            sobra = sobra % moedas;

            moedas = 50;
            quociente = sobra / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            sobra = sobra % moedas;

            moedas = 25;
            quociente = sobra / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            sobra = sobra % moedas;

            moedas = 10;
            quociente = sobra / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            sobra = sobra % moedas;

            moedas = 5;
            quociente = sobra / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            sobra = sobra % moedas;

            moedas = 1;
            quociente = sobra / moedas;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.01");
            sobra = sobra % moedas;


        }
    }
}
