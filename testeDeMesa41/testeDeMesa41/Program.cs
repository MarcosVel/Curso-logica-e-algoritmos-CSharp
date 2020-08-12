using System;

namespace testeDeMesa41
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 4;

            while (x < 3)
            {
                y += 2;
                x += 1;
                Console.WriteLine(x + " - " + y);
            }

        }
    }
}
