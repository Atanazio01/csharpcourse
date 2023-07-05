using HotelVectorsFixationExercise;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Students[] students = new Students[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();
                students[room] = new Students(name, email);
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 1;i <= students.Length;i++) {
                if (students[i] != null)
                {
                    Console.WriteLine($"{i}: {students[i]}");
                }
            }
        }
    }
}