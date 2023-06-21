using System.Globalization;
using System.Xml.Linq;

namespace PropartiesAcessors
{
    internal class Product
    {
        private string _name;
        private double _price;
        private int _amount;

        public Product()
        {
        }

        public Product(string name, double price, int amount)
        {
            _name = name;
            _price = price;
            _amount = amount;
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

        public double Price
        {
            get => _price;
        }

        public double Amount
        {
            get => _amount;
        }

        public double TotalAmountInStock()
        {
            return _price * _amount;
        }

        public void AddProduct(int amount)
        {
            _amount += amount;
        }

        public void RemoveProduct(int amount)
        {
            _amount -= amount;
        }

        public override string ToString()
        {
            return $"{_name}, " +
                $"$ {_price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{_amount} unidades, " +
                $"Total: {TotalAmountInStock().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}