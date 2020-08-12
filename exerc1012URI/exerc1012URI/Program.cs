using System;
using System.Globalization;

namespace exerc1012URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, areaTriRet, areaCirc, areaTrap, areaQuad, areaRet, pi = 3.14159;

            string[] numeros = Console.ReadLine().Split(' ');

            A = double.Parse(numeros[0]);
            B = double.Parse(numeros[1]);
            C = double.Parse(numeros[2]);

            areaTriRet = (A * C) / 2; //TRIANGULO RETANGULO
            areaCirc = pi * Math.Pow(C, 2.0); //AREA CIRCULO
            areaTrap = ((A + B) * C) / 2; //AREA TRAPEZIO
            areaQuad = Math.Pow(B, 2.0); //AREA QUADRADO
            areaRet = A * B; //AREA RETANGULO

            Console.WriteLine("TRIANGULO: " + areaTriRet.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirc.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrap.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuad.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRet.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
