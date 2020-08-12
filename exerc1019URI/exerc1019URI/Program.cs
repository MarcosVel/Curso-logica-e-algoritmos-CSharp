using System;

namespace exerc1019URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, resto, seg, min, hr, tempo;

            N = int.Parse(Console.ReadLine());

            hr = N / 3600;
            resto = N % 3600;

            min = resto / 60;
            seg = resto % 60;

            Console.WriteLine(hr + ":" + min + ":" + seg);

        }
    }
}
