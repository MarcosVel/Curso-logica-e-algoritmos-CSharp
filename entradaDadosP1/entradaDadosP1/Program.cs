using System;

namespace entradaDadosP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o que quiser:");

            string frase = Console.ReadLine();

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
                      
            string[] v = Console.ReadLine().Split(' '); //o Console.ReadLine() antes do split faz com que seja lido.
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("");
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}   // FEITO NA AULA 17 DO CURSO DE C# primeiros passos
