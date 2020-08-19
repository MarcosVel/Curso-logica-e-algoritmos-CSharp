using System;
using System.ComponentModel;

namespace exerc1075URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++) {                
                if (i % N == 2) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
