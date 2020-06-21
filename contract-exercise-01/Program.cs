using System;
using System.Globalization;
using Course.Entities;
using Course.Services;

namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter contract data");
      Console.Write("Number: ");
      int number = int.Parse(Console.ReadLine());
      Console.Write("Date (dd/mm/yyyy): ");
      DateTime date = DateTime.Parse(Console.ReadLine());
      Console.Write("Contract value: ");
      double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Enter number of payments: ");
      int numberPayments = int.Parse(Console.ReadLine());

      Contract contract = new Contract(number, date, value);
      ContractService contractService = new ContractService(new PaypalPaymentService());
      contractService.ProcessContract(contract, numberPayments);

      Console.WriteLine();
      Console.WriteLine("Payments:");
      foreach (Payment payment in contract.Payments)
      {
        Console.WriteLine(payment);
      }
    }
  }
}
