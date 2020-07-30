using System;
using System.Globalization;

namespace exerc1014URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int X; //distancia total percorrida
            double Y, media; //Y = total de combustível gasto            

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());

            media = X / Y;

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}
