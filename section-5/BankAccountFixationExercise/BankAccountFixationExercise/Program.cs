using System;
using System.Globalization;

namespace BankAccountFixationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account;

            Console.Write("Entre com o número da conta: ");
            int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com o nome do títular da conta: ");
            string name = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char haveInitialDeposit = char.Parse(Console.ReadLine());
            if (haveInitialDeposit == 's' || haveInitialDeposit == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new BankAccount(number, name, initialDeposit);
            }else
            {
                account = new BankAccount(number, name);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(account);

            Console.Write("\nEntre com um valor para depósito: ");
            double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(deposit);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(account);

            Console.Write("\nEntre com um valor para saque: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.WithDraw(withdraw);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(account);
        }
    }
}