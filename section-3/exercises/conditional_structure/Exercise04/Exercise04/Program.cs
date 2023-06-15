using System;
using System.Globalization;

namespace Exercise01

/*
 * Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] hours = Console.ReadLine().Split(' ');
            int start = int.Parse(hours[0]);
            int finish = int.Parse(hours[1]);
            int duration = 0;

            if (start >= finish)
            {
                duration = (finish - start) + 24;
                Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
            }
            else
            {
                duration = finish - start;
                Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
            }
        }
    }
}