using System;
using System.Globalization;

namespace Exercise01

/*
 * Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
mostre: 
a) a área do triângulo retângulo que tem A por base e C por altura. 
b) a área do círculo de raio C. (pi = 3.14159) 
c) a área do trapézio que tem A e B por bases e C por altura. 
d) a área do quadrado que tem lado B. 
e) a área do retângulo que tem lados A e B
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            double a = double.Parse(numbers[0], CultureInfo.InvariantCulture);
            double b = double.Parse(numbers[1], CultureInfo.InvariantCulture);
            double c = double.Parse(numbers[2], CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double triangle = (a * c) / 2;
            double radius = pi * Math.Pow(c, 2);
            double trapeze = ((a + b) * c) / 2;
            double square = b * b;
            double rectangle = a * b;

            Console.WriteLine($"TRIANGULO: {triangle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {radius.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapeze.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {square.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {rectangle.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}