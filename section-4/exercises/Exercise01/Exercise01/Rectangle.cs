using System.Globalization;

namespace Exercise01
{
    internal class Rectangle
    {
        public double Width;
        public double Height;

        public double Area()
        {
            return (Width * Height);
        }

        public double Perimeter()
        {
            return 2 * (Width + Height);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Width, 2) + Math.Pow(Height, 2)));
        }

        public override string ToString()
        {
            return $"ÁREA = {Area().ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nPERÍMETRO = {Perimeter().ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nDIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
