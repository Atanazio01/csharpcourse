using System;
using System.Globalization;

namespace Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.Write("Nome do aluno: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            student.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(student);
        }
    }
}