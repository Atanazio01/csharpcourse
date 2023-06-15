using System;
using System.Globalization;

namespace Exercise01

/*
 * Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
ordem crescente ou decrescente.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] number = Console.ReadLine().Split(' ');
            int number1 = int.Parse(number[0]);
            int number2 = int.Parse(number[1]);

            if (number1 % number2 == 0 || number2 % number1 == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }
        }
    }
}