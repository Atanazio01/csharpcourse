using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom dia!"); // Escreve no console sem quebra de linha no final
            Console.WriteLine("Boa tarde!"); // Escreve no console com quebra de linha no final
            Console.WriteLine("Boa noite!");
            Console.WriteLine("--------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); /* Desconsidera variações 
                                                                                    na formatação entre paises
            como o '.' e a ',' por exemplo*/
            Console.WriteLine("\n--------------------------------------------------------\n");

            // Placeholders, concatenação e interpolação

            //Placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //Interpolação - técnica mais nova
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Concatenção - técnica mais antiga
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}