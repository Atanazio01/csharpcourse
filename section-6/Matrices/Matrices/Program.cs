using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[4, 3];

            Console.WriteLine(mat.Length); // Quantos elementos a matriz possui

            Console.WriteLine(mat.Rank); // Quantas dimensões a matriz tem
            
            Console.WriteLine(mat.GetLength(0)); // Quantos elementos na primeira dimensão(linhas)

            Console.WriteLine(mat.GetLength(1)); // Quantos elementos na segunda dimensao(colunas)
        }
    }
}