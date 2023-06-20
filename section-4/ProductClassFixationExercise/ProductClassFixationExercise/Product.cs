using System.Globalization;

namespace ProductClassFixationExercise
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Amount;

        public double TotalAmountInStock()
        {
            return Price * Amount;
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
