namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] part1 = Console.ReadLine().Split(' ');
            string[] part2 = Console.ReadLine().Split(' ');

            int codePart1 = int.Parse(part1[0]);
            int quantityPart1 = int.Parse(part1[1]);
            double valuePart1 = double.Parse(part1[2]);

            int codePart2 = int.Parse(part2[0]);
            int quantityPart2 = int.Parse(part2[1]);
            double valuePart2 = double.Parse(part2[2]);

            double amountPayable = (quantityPart1 * valuePart1 + quantityPart2 * valuePart2);

            Console.WriteLine($"VALOR A PAGAR: R$ {amountPayable.ToString("F2")}");
        }
    }
}
