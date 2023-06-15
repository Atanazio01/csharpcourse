using System;
using System.Reflection;

namespace SintaxeFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double result = Bigger(n1, n2, n3);

            Console.WriteLine("Maior = " + result);
        }

        static int Bigger(int a, int b, int c) {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if(b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}