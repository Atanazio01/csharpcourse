namespace ImplicitConversionAndCasting {
  class Program {
    static void Main(string[] args) {
      float x = 4.5f;
      // conversao implícita
      double y = x;

      double a;
      float b;
      a = 5.1;
      // conversão explícita
      b = (float)a; // casting

      int c = (int)a; // casting

      System.Console.WriteLine(y);
      System.Console.WriteLine(b);
      System.Console.WriteLine(c);
    }
  }
}