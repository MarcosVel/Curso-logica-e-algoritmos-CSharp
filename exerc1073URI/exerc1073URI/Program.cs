using System;

namespace exerc1073URI
{
    class Program
    {
        static void Main(string[] args)
        {          
            int quadrado, N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                if (i % 2 == 0) {
                    quadrado = (int) Math.Pow(i, 2.0);
                    Console.WriteLine(i + "^2 = " + quadrado);
                }
            }

        }
    }
}
