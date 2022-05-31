using System;

namespace ExecMatrizes_Abstração_de_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de Matriz

            //     [ 5   8   3   2   9 ]
            //     [ 9   0   1   4   2 ]
            //     [ 7   8   1   2   0 ]
            //     [ 6   2   6   9   1 ]
            //     [ 3   9   7   2   2 ]

            // Diagonal Principal da Matriz: 5   0   1   9   2

            int[,] Matriz = new int[5, 5];          // Declaração da Matriz
            int[] VetorResultante = new int[5];     // Declaração do Vetor Resultante

            for (int i = 0; i < 5; i++)             // Para cada linha da Matriz
            {
                for (int j = 0; j < 5; j++)         // Para cada coluna da Matriz
                {
                    Console.Write($"Elemento ({i + 1},{j + 1}): ");

                    Matriz[i, j] = int.Parse(Console.ReadLine());   // Lê o valor do elemento
                }
            }

            // Chamada à Função
            // Envia a Matriz e recebe como resultado um vetor

            VetorResultante = ExtraiDiagPrinc(Matriz);

            Console.Write("\n\nDiagonal Principal: ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{VetorResultante[i],7}");
            }

            Console.WriteLine("\n");

            Console.ReadKey();
        }

        static int[] ExtraiDiagPrinc(int[,] M)
        {
            int[] Result = new int[5];

            for (int i = 0; i < 5; i++)         // Para cada linha da Matriz
            {
                for (int j = 0; j < 5; j++)     // Para cada coluna da Matriz
                {
                    if (i == j)                 // Estamos na Diagonal principal?
                    {
                        Result[i] = M[i, j];    // Alimentamos o Vetor
                    }
                }
            }

            return Result;
        }
    }
}

