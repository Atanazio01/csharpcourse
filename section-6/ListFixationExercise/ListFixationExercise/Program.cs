using System;
using System.Globalization;

namespace ListFixationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee # {i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int employeeIncreaseId = int.Parse(Console.ReadLine());

            foreach (Employee employee in employees)
            {
                if (employee.Id == employeeIncreaseId)
                {
                    Console.Write("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employee.increaseSalary(percentage);
                }
                else
                {
                    Console.WriteLine("This id does not exist!");
                }
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

        }
    }
}