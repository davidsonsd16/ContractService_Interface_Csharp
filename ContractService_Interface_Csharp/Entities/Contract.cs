using System;
using System.Collections.Generic;
using System.Text;

namespace ContractService_Interface_Csharp.Entities {
    class Contract {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; set; }
        public List<Installment> installments { get; private set; } = new List<Installment>();

        public Contract() { }

        public Contract(int number, DateTime date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void AddInstallment(Installment installment) {
            installments.Add(installment);
        }
        public void RemoveInstallment(Installment installment) {
            installments.Remove(installment);
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Installments");
            foreach (Installment installment in installments) {
                sb.AppendLine(installment.ToString());
            }
            return sb.ToString();
        }
    }
}
