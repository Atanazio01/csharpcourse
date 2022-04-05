namespace Exercise02
{
    class Program
    {
        static void Main(string[] args) {
          double raio = double.Parse(Console.ReadLine());
          double pi = 3.14159;
          double area = pi * Math.Pow(raio, 2);

          Console.WriteLine($"A = {area.ToString("F4")}");
        }
    }
}
