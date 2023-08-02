namespace OverlayVirtualWordsOverrideAndBase.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += InterestRate * Balance;
        }

        public override void WithDraw(double amount)
        {
            base.WithDraw(amount); // a palavra base implementa a logica do metodo da superclasse
            Balance -= 2.0;
        }
    }
}
