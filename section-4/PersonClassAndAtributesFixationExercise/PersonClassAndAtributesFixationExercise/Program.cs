using System;

namespace PersonClassAndAtributesFixationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();

            Console.WriteLine("Dados da primeira pessoa:");
            person1.Name = Console.ReadLine();
            person1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            person2.Name = Console.ReadLine();
            person2.Age = int.Parse(Console.ReadLine());

            if(person1.Age > person2.Age)
            {
                Console.WriteLine("Pessoa mais velha: " + person1.Name);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + person2.Name);
            }
        }
    }
}