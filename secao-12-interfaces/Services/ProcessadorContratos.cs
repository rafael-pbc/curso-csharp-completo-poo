using ProcessadorContratos.Entities;

namespace ProcessadorContratos.Services
{
    public class ContractService
    {
        private readonly IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);

                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);

                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);

                contract.AddInstallment(new Installment(dueDate, fullQuota));
            }
        }
    }
}