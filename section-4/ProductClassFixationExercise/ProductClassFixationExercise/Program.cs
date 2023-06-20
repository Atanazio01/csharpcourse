using System;
using System.Globalization;

namespace ProductClassFixationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.Write("\nDigite o número de produtos a ser adicionado no estoque: ");
            int amount = int.Parse(Console.ReadLine());
            p.AddProduct(amount);
            Console.WriteLine("\nDados do produto: " + p);

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            amount = int.Parse(Console.ReadLine());
            p.RemoveProduct(amount);
            Console.WriteLine("\nDados do produto: " + p);

        }
    }
}