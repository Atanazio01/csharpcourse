using System;
using System.Globalization;

namespace Exercise01

/*
 * Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] product1 = Console.ReadLine().Split(' ');
            string[] product2 = Console.ReadLine().Split(' ');

            int partCode1 = int.Parse(product1[0]);
            int numberOfPieces1 = int.Parse(product1[1]);
            double priceOfPiece1 = double.Parse(product1[2], CultureInfo.InvariantCulture);

            int partCode2 = int.Parse(product2[0]);
            int numberOfPieces2 = int.Parse(product2[1]);
            double priceOfPiece2 = double.Parse(product2[2], CultureInfo.InvariantCulture);

            double priceToPay = (numberOfPieces1 * priceOfPiece1) + (numberOfPieces2 * priceOfPiece2);
            Console.WriteLine($"VALOR A PAGAR = {priceToPay.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}