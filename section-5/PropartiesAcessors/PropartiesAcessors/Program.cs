﻿using System;
using System.Globalization;
namespace PropartiesAcessors
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("TV", 500.00, 10);

            p.Name = "T";

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);
        }
    }
}