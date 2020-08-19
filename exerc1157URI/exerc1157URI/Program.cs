using System;

namespace exerc1157URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                if (N % i == 0) {                   
                    Console.WriteLine(i);
                }

            }
        }
    }
}
