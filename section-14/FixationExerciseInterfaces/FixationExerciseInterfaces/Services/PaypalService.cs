namespace FixationExerciseInterfaces.Services
{
    internal class PaypalService : OnlinePaymentService
    {

        public double Interest(double amount, int months)
        {
            return amount + ((0.01 * amount) * months);
        }
        public double PaymentFee(double amount)
        {
            return amount + (0.02 * amount);
        }
    }
}
