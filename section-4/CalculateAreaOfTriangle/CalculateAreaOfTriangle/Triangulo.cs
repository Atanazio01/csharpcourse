namespace CalculateAreaOfTriangle
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
