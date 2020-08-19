using System;

namespace exerc1072URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()), 
                quantIN = 0, 
                quantOUT = 0;

            for (int i = 0; i < N; i++) {
                int X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20) {
                    quantIN += 1;
                }
                else {                    
                    quantOUT += 1;                    
                }

            }

            Console.WriteLine(quantIN + " in");
            Console.WriteLine(quantOUT + " out");
            
        }
    }
}
