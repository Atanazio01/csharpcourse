using System;

namespace SolvedExerciseMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            List<int> mainDiagonal = new List<int>();
            List<int> negativeNumbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(linha[j]);
                    if (i == j)
                    {
                        mainDiagonal.Add(mat[i, j]);
                    }
                    if (mat[i, j] < 0)
                    {
                        negativeNumbers.Add(mat[i, j]);
                    }
                }
            }

            Console.WriteLine("Main diagonal:");
            foreach (int i in mainDiagonal)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nNegative numbers = " + negativeNumbers.Count);
        }
    }
}