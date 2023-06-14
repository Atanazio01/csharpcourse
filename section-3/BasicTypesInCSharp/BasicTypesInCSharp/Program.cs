using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool completo = false; // true or false
            char genero = '\u0041'; // 1 character or Unicode 
            sbyte x = 100; // 0 to 255
            byte n1 = 126; // -126 to 127
            int n2 = 1000; // -2147483647 to 2147483647
            int n3 = 2147483647; // -2147483647 to 2147483647
            long n4 = 2147483648L; // -9.223.372.036.854.775.999 to -9223372036854775999
            float n5 = 4.5f; // floating point numbers float
            double n6 = 4.5; // floating point numbers double
            string nome = "Maria Green"; // string // imutavel
            object obj1 = "Alex Brown"; // toda classe em c# é uma subclasse de object
            object obj2 = 4.5f; // toda classe em c# é uma subclasse de object

            Console.WriteLine("bool " + completo);
            Console.WriteLine("char " + genero);
            Console.WriteLine("sbyte " + x);
            Console.WriteLine("byte " + n1);
            Console.WriteLine("int " + n2);
            Console.WriteLine("int " + n3);
            Console.WriteLine("long " + n4);
            Console.WriteLine("float " + n5);
            Console.WriteLine("double " + n6);
            Console.WriteLine("string " + nome);
            Console.WriteLine("object " + obj1);
            Console.WriteLine("object " + obj2);

            /* Todo tipo numérico tem uma propriedade MinValue e uma MaxValue
            para encontrar o valor minimo e máximo (ex. int.MinValue - decimal.MaxValue) */
        }
    }
}