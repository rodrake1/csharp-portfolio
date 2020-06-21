using System;
using System.Collections.Generic;

namespace Course.Entities
{
  class Contract
  {
    public int Number { get; set; }
    public DateTime Date { get; set; }
    public double TotalValue { get; set; }
    public List<Payment> Payments { get; set; }

    public Contract(int number, DateTime date, double totalValue)
    {
      Number = number;
      Date = date;
      TotalValue = totalValue;
      Payments = new List<Payment>();
    }

    public void AddPayment(Payment payment)
    {
      Payments.Add(payment);
    }
  }
}