using System;
using System.Globalization;

namespace VectorsFixationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] products = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name  = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                products[i] = new Product(name, price); // poderia ser usada a sintaxe automatica sem construct {}
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += products[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}