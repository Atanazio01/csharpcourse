namespace Exercise06 {
  class Program {
    static void Main(string[] args) {
      string[] values = Console.ReadLine().Split(' ');
      double a = double.Parse(values[0]);
      double b = double.Parse(values[1]);
      double c = double.Parse(values[2]);
      double pi = 3.14159;

      double triangulo = (a * c) / 2;
      double circulo = pi * Math.Pow(c, 2);
      double trapezio = ((a+b)*c) / 2;
      double quadrado = b*b;
      double retangulo = a*b;


      Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3")}");
      Console.WriteLine($"CIRCULO: {circulo.ToString("F3")}");
      Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3")}");
      Console.WriteLine($"QUADRADO: {quadrado.ToString("F3")}");
      Console.WriteLine($"RETANGULO: {retangulo.ToString("F3")}");
    }
  }
}