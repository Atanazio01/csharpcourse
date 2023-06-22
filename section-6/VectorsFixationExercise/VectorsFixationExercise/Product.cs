namespace VectorsFixationExercise
{
    internal class Product
    {
        public string Name { get; private set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
}
