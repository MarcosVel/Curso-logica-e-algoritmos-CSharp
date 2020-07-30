using System;
using System.Globalization;

namespace exerc1008URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFunc, hrsTrab;
            double valorHR, salario;

            numFunc = int.Parse(Console.ReadLine());
            hrsTrab = int.Parse(Console.ReadLine());
            valorHR = double.Parse(Console.ReadLine());

            salario = hrsTrab * valorHR;

            Console.WriteLine("NUMBER = " + numFunc);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));            
        }
    }
}
