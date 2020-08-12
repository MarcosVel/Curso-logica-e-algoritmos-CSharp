using System;

namespace exerc1013URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorAB, total;

            string[] num = Console.ReadLine().Split(' ');

            a = int.Parse(num[0]);
            b = int.Parse(num[1]);
            c = int.Parse(num[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;

            total = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(total + " eh o maior");

        }
    }
}
