using System;
using System.Globalization;

namespace Exercise01

/*
 * Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("POSITIVO");
            }
        }
    }
}