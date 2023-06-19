using System;
using System.Globalization;

namespace EmployeeClassAndAtributesFixationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            employee1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            employee1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            employee2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            employee2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double AveragSalary = (employee1.Salary + employee2.Salary) / 2;

            Console.WriteLine("Salário médio = " + AveragSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}