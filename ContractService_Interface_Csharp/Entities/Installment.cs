using System;
using System.Globalization;

namespace ContractService_Interface_Csharp.Entities {
    class Installment {
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public override string ToString() {
            return Date.ToString("dd/MM/yyyy") + " - " + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
