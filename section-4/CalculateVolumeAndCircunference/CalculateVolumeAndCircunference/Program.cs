using System.Globalization;

namespace CalculateVolumeAndCircunference
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculator.Circunference(radius);
            double volume = Calculator.Volume(radius);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}