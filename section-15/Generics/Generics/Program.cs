namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                printService.AddValue(int.Parse(Console.ReadLine()));
            }
            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}