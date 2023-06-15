using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;

            double y = x; /* conversão implicita de tipos, a variavel y é double e recebeu
                           o conteudo de x que é float, float tem 4 bytes enquanto double tem 8*/
            Console.WriteLine(y);

            double a;
            float b;
            a = 5.1;
            b = (float)a; /*Conversão explicita de tipos, pois 8 bytes nao cabem em 4 bytes*/
            Console.WriteLine(b);

            double c = 5.1;
            int d;
            d = (int)c; // Conversão explicita com perca de dados, valores decimais truncados
            Console.WriteLine(d); 

            int e = 5;
            int f = 2;
            double result = (double)e / f; /*nesse caso precisamos fazer o casting em uma das variaveis
                                            pois como as duas sao int, o compilador entende que se espera
                                            um valor int de saída*/

            Console.WriteLine(result);

        }
    }
}