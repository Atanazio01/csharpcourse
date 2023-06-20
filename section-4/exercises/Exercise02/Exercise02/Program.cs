using System;
using System.Globalization;

namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.Write("Nome: ");
            employee.Name = Console.ReadLine();

            Console.Write("Salário bruto: ");
            employee.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + employee);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee.IncreaseSalary(percentage);

            Console.WriteLine("Dados atualizados: " + employee);
        }
    }
}