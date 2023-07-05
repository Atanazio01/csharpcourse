using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            foreach (string s in vect)
            {
                Console.WriteLine(s);
            }
        }
    }
}