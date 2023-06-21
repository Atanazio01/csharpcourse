namespace CurrencyConverterFixationExercise
{
    internal class CurrencyConverter
    {
        public static double Iof = 6.38;
        public static double Converter(double quotation, double dollars)
        {
            double total = quotation * dollars;
            return total + (Iof * (total / 100));
        }
    }
}
