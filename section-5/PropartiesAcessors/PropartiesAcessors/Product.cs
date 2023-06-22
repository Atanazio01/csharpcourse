using System.Globalization;
using System.Xml.Linq;

namespace PropartiesAcessors
{
    internal class Product
    {
        private string _name;
        public double Price { get; private set; }
        public int Amount { get; private set; }

        public Product()
        {
        }

        public Product(string name, double price, int amount)
        {
            _name = name;
            Price = price;
            Amount = amount;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
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
            return $"{_name}, " +
                $"$ {Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{Amount} unidades, " +
                $"Total: {TotalAmountInStock().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}