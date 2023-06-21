using System.Globalization;

namespace CalculateVolumeAndCircunference
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.Write("Entre com o valor do raio: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunference(radius);
            double volume = calc.Volume(radius);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}