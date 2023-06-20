using System;
using System.Globalization;

namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Entre com a largura e altura do retângulo:");
            rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(rectangle);

        }
    }
}