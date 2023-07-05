using System;

namespace ParamsParameterModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int s1 = Calculator.Sum(new int[] { 2, 3, 4, 5, 6, 7 }); // sem o modificador params 
            int s2 = Calculator.Sum(1, 2);

            //Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}