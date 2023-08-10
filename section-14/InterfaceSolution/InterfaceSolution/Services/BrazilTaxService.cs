namespace InterfaceSolution.Services
{
    internal class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if(amount <= 1000)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
