using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100; // 0 to 255
            byte n1 = 126; // -126 to 127
            int n2 = 1000; // -2147483647 to 2147483647
            int n3 = 2147483647; // -2147483647 to 2147483647
            long n4 = 2147483648L; // -9.223.372.036.854.775.999 to -9.223.372.036.854.775.999


            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}