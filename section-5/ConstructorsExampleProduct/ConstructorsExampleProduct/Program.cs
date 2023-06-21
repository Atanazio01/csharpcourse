using ConstructorsExampleProduct;
using System;
using System.Globalization;

namespace ConstructorsExampleProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product p = new Product(name, price);

            Product p2 = new Product();

            Product p3 = new Product
            {
                Name = "TV",
                Price = 500.00,
                Amount = 20,
            };

            Console.WriteLine("Dados do produto: " + p);

            Console.Write("\nDigite o número de produtos a ser adicionado no estoque: ");
            int addAmount = int.Parse(Console.ReadLine());
            p.AddProduct(addAmount);
            Console.WriteLine("\nDados do produto: " + p);

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            int removeAmount = int.Parse(Console.ReadLine());
            p.RemoveProduct(removeAmount);
            Console.WriteLine("\nDados do produto: " + p);

        }
    }
}