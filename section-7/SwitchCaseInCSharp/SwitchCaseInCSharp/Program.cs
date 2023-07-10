using System;

namespace SwitchCaseInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            string day = "";

            while (day != "Invalid Date")
            {
                Console.Write("Informe o dia da semana para ver sua tradução em inglês: ");
                x = Console.ReadLine();
                switch (x)
                {
                    case "domingo":
                        day = "Sunday"; break;
                    case "segunda":
                        day = "Monday"; break;
                    case "terça":
                        day = "Tuesday"; break;
                    case "quarta":
                        day = "Wednesday"; break;
                    case "quinta":
                        day = "Thursday"; break;
                    case "sexta":
                        day = "Friday"; break;
                    case "sábado":
                        day = "Saturday"; break;
                    default:
                        day = "Invalid Date"; break;
                }

                Console.WriteLine($"Day: {day}");
            }
        }
    }
}