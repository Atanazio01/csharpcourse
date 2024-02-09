using ExtensionMethods.Extensions;

namespace Class226.ExtensionMethods;
    class Program
{
    static void Main(string[] args)
    {
        DateTime dt = new DateTime(2024, 02, 09, 8, 10, 45);
        Console.WriteLine(dt.ElapsedTime());

        string str = "This is a very long string";
        Console.WriteLine(str.Cut(10));
    }
}
