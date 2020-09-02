using System;
using System.Globalization;

namespace exercPropost06Matriz {
    class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            double[,] matriz = new double[N, N];

            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = double.Parse(vet[j]);
                }
            }

            int linhaEscolhida = int.Parse(Console.ReadLine());
            int colunaEscolhida = int.Parse(Console.ReadLine());

            //SOMA
            double soma = 0;
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (matriz[i, j] > 0.0) {
                        soma += matriz[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

            //LINHA
            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j < N; j++) {
                Console.Write(matriz[linhaEscolhida, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            //COLUNA
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++) {
                Console.Write(matriz[i, colunaEscolhida].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            //DIAGONAL
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++) {
                Console.Write(matriz[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            //MATRIZ ALTERADA
            Console.WriteLine("MATRIZ ALTERADA: ");
            for (int i = 0; i < N; i++) {                
                for (int j = 0; j < N; j++) {
                    if (matriz[i, j] < 0.0) {
                        matriz[i, j] = Math.Pow(matriz[i, j], 2);
                    }
                    Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
