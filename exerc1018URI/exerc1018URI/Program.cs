using System;

namespace exerc1018URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, cedulas, sobra, quociente;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            sobra = N;

            cedulas = 100;
            quociente = sobra / cedulas;
            Console.WriteLine(quociente + " nota(s) de R$ " + cedulas + ",00");
            sobra = sobra % cedulas;

            cedulas = 50;
            quociente = sobra / cedulas;
            Console.WriteLine(quociente + " nota(s) de R$ " + cedulas + ",00");
            sobra = sobra % cedulas;

            cedulas = 20;
            quociente = sobra / cedulas;
            Console.WriteLine(quociente + " nota(s) de R$ " + cedulas + ",00");
            sobra = sobra % cedulas;

            cedulas = 10;
            quociente = sobra / cedulas;
            Console.WriteLine(quociente + " nota(s) de R$ " + cedulas + ",00");
            sobra = sobra % cedulas;

            cedulas = 5;
            quociente = sobra / cedulas;
            Console.WriteLine(quociente + " nota(s) de R$ " + cedulas + ",00");
            sobra = sobra % cedulas;

            cedulas = 2;
            quociente = sobra / cedulas;
            Console.WriteLine(quociente + " nota(s) de R$ " + cedulas + ",00");
            sobra = sobra % cedulas;

            cedulas = 1;
            quociente = sobra / cedulas;
            Console.WriteLine(quociente + " nota(s) de R$ " + cedulas + ",00");            

        }
    }
}
