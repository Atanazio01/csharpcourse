namespace Exercise04 {
  class Program {
    static void Main(string[] args) {
      int employeeNumber = int.Parse(Console.ReadLine());
      int workedHours = int.Parse(Console.ReadLine());
      double hourlySalary = double.Parse(Console.ReadLine());

      double salary = workedHours * hourlySalary;

      Console.WriteLine($"NUMBER = {employeeNumber}");
      Console.WriteLine($"SALARY = U$ {salary.ToString("F2")}");
    }
  }
}