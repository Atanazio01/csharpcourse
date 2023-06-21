using System;
using System.Globalization;

namespace CurrencyConverterFixationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double quotation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dollars = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = CurrencyConverter.Converter(quotation, dollars);
            Console.WriteLine("Valor a ser pago em reais = " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}