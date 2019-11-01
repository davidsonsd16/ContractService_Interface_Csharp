using ContractService_Interface_Csharp.Entities;

namespace ContractService_Interface_Csharp.Services {
    interface IPaymentService {
        public double ValueQuota(double amount, int month);
    }
}
