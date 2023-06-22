using System;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? x = null; //declaração de variaveis null
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); // Se o valor for null, retorna o valor padrão do tipo
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); // Verifica se a variavel tem um valor ou não
            Console.WriteLine(y.HasValue);

            if(x.HasValue)
                Console.WriteLine(x.Value); /* Retorna o valor da variavel, caso tente 
                                             * acessar o valor de uma variavel null vai dar erro*/
            else
                Console.WriteLine("X is null");
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            //Operador de coalescência nula

            double? a = null;
            double? b = 10;

            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}