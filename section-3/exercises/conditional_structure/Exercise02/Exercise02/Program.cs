using System;
using System.Globalization;

namespace Exercise01

/*
 * Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}