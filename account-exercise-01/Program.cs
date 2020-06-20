using System;
using System.Globalization;
using Course.Entities;
using Course.Entities.DomainExceptions;

namespace Course
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter account data");
      Console.Write("Number: ");
      int number = int.Parse(Console.ReadLine());
      Console.Write("Holder: ");
      string holder = Console.ReadLine();
      Console.Write("Balance: ");
      double balance = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
      Console.Write("Withdraw limit: ");
      double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
      Account account = new Account(number, holder, balance, withdrawLimit);

      Console.WriteLine();
      Console.Write("Enter amount for withdraw: ");
      double amount = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
      try
      {
        account.Withdraw(amount);
        Console.WriteLine($"New balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
      }
      catch (DomainException e)
      {
        Console.WriteLine($"Withdraw error: {e.Message}");
      }
    }
  }
}
