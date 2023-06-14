using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product1 = "Computador";
            string product2 = "Mesa de escritório";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", product1, price1); // placeholder
            Console.WriteLine(product2 + ", cujo preço é $ " + price2.ToString("F2")); // concatenacao
            Console.WriteLine($"Registro: {age} anos de idade, codigo {code} e genêro: {gender}"); // interpolacao
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: " + measure.ToString("F8"));
            Console.WriteLine("Arredondado (três casas decimais): " + measure.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + measure.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}