using System;
using System.Globalization;

namespace Course.Entities
{
  class Payment
  {
    public DateTime DueDate { get; set; }
    public double Amount { get; set; }

    public Payment(DateTime dueDate, double amount)
    {
      DueDate = dueDate;
      Amount = amount;
    }

    public override string ToString()
    {
      return $"{DueDate.ToString("dd/MM/yyyy")} - {Amount.ToString("F2", CultureInfo.InvariantCulture)}";
    }
  }
}