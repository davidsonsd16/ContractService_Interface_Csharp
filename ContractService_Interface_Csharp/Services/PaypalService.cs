

namespace ContractService_Interface_Csharp.Services {
    class PaypalService : IPaymentService {
        private const double PaymentFee = 0.02;
        private const double InterestMonth = 0.01;

        public double ValueQuota(double amount, int month) {
            return (amount * (1.0 + InterestMonth * month)) * (1.0 + PaymentFee);
        }
    }
}
