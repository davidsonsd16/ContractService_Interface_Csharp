using System;
using ContractService_Interface_Csharp.Entities;

namespace ContractService_Interface_Csharp.Services {
    class ContractService {
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService) {
            _paymentService = paymentService;
        }

        public void ProcessContractService(Contract contract, int number) {
            double basicQuota = contract.TotalValue / number;
            for(int i = 1; i <= number; i++) {
                DateTime date = contract.Date.AddMonths(i);
                double quota = _paymentService.ValueQuota(basicQuota, i);
                contract.AddInstallment(new Installment(date,quota));
            }
        }
    }
}
