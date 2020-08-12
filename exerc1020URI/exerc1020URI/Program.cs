using System;

namespace exerc1020URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, resto, ano, mes, dia;

            x = int.Parse(Console.ReadLine());

            ano = x / 365;
            resto = x % 365;
            mes = resto / 30;
            dia = resto % 30;
            
            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");

        }
    }
}
