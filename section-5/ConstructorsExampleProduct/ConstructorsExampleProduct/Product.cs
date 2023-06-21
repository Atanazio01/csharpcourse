using System.Globalization;

namespace ConstructorsExampleProduct
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

        public string GetName() { return _name; }

        public double GetPrice() { return _price; }

        public int GetAmount() { return _amount; }

        public void SetName(string name)
        {
            if (name != null && name.Length > 1)
            {
                _name = name;
            }
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