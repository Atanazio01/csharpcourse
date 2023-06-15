using System;
using System.Globalization;

namespace Exercise01

/*
 * Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
decimais.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int code = int.Parse(Console.ReadLine());
            int workedHours = int.Parse(Console.ReadLine());
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = workedHours * valuePerHour;

            Console.WriteLine($"NUMBER = {code}");
            Console.WriteLine($"SALARY = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}