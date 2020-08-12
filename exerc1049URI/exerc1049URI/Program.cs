using System;

namespace exerc1049URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string plv1, plv2, plv3;

            plv1 = Console.ReadLine();
            plv2 = Console.ReadLine();
            plv3 = Console.ReadLine();

            if (plv1 == "vertebrado")
            {
                if (plv2 == "ave")
                {
                    if (plv3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                } else
                {
                    if (plv3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (plv2 == "inseto")
                {
                    if (plv3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    } 
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                } else
                {
                    if (plv3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

        }
    }
}
