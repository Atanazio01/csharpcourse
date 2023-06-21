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
        }

        public Product(string name, double price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            Amount = 5; // dispensável
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