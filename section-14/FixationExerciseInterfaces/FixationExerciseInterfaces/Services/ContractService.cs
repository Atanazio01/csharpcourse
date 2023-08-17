using FixationExerciseInterfaces.Entities;

namespace FixationExerciseInterfaces.Services
{
    internal class ContractService
    {
        OnlinePaymentService _onlinePaymentService;

        public ContractService(OnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double valueInstallments = contract.TotalValue / months;
            Console.WriteLine(valueInstallments);

            for (int i = 1; i <= months; i++)
            {
                double interest = _onlinePaymentService.Interest(valueInstallments, i);
                double paymentFee = _onlinePaymentService.PaymentFee(interest);
                contract.Installments.Add(new Installment(contract.Date.AddMonths(i), paymentFee));
            }
        }
    }
}
