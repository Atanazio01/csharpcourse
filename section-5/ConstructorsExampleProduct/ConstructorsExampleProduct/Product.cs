using System.Globalization;

namespace ConstructorsExampleProduct
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Amount;

        public Product()
        {
            Amount = 10;
        }

        public Product(string name, double price) : this()
        {
            Name = name;
            Price = price;
        }

        public Product(string name, double price, int amount) : this (name, price)
        {
            Amount = amount;
        }

        public double TotalAmountInStock()
        {
            return Price * Amount;
        }

        public void AddProduct(int amount)
        {
            Amount += amount;
        }

        public void RemoveProduct(int amount)
        {
            Amount -= amount;
        }

        public override string ToString()
        {
            return $"{Name}, " +
                $"$ {Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{Amount} unidades, " +
                $"Total: {TotalAmountInStock().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}