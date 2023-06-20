using System.Globalization;

namespace Exercise02
{
    internal class Employee
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary()
        {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double percentage)
        {
            GrossSalary += percentage * (GrossSalary / 100.0);
        }

        public override string ToString()
        {
            return $"{Name}, $ {NetSalary().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
