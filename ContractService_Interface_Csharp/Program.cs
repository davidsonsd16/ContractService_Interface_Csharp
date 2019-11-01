using System;
using System.Globalization;
using ContractService_Interface_Csharp.Entities;

namespace ContractService_Interface_Csharp {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, value);
            
            Console.Write("Enter number of installments: ");
            int n = int.Parse(Console.ReadLine());

            //

            Console.WriteLine(contract);
        }
    }
}
