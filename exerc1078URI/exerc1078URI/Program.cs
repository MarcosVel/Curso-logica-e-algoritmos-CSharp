using System;

namespace exerc1078URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int conta, i, N = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++) {
                conta = N * i;
                Console.WriteLine(i + " x " + N + " = " + conta);
            }

        }
    }
}
