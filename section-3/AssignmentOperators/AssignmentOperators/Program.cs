using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2; // soma o que já tinha em 'a' com 2;
            Console.WriteLine(a);

            a *= 3; // mesma coisa com multiplicacao
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF"; // também funciona com strings
            Console.WriteLine(s);

            int b = 10;
            b++; // incrementa +1 ao valor b++ === (b = b + 1)
            Console.WriteLine(b);
            b--;
            Console.WriteLine(b); // decrementa o valor b-- === (b = b - 1)

            int c = 10;
            Console.WriteLine(c);
            int d = c++; // nesse caso, 'd' recebe o valor de 'c' antes de 'c' ser incrementado
            Console.WriteLine(d);
            d = ++c; // nesse caso, 'd' recebe o valor de 'c' depois de 'c' ser incrementado
            Console.WriteLine(d);
        }
    }
}