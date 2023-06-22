using System.Globalization;

namespace BankAccountFixationExercise
{
    internal class BankAccount
    {
        private string _name;
        public int Number { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public BankAccount(int number, string name, double initialDeposit) : this(number, name)
        {
            Deposit(initialDeposit);
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        public void Deposit(double quantity)
        {
            Balance += quantity;
        }

        public void WithDraw(double quantity)
        {
            Balance -= (quantity + 5.00);
        }

        public override string ToString()
        {
            return $"Conta {Number}, Titular: {_name}, Saldo: $ {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
