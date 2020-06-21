using System;
using Course.Entities;

namespace Course.Services
{
  class ContractService
  {
    private IPaymentService _paymentService;

    public ContractService(IPaymentService paymentService)
    {
      _paymentService = paymentService;
    }

    public void ProcessContract(Contract contract, int months)
    {
      double baseAmount = contract.TotalValue / months;
      for (int quota = 1; quota <= months; quota++)
      {
        DateTime dueDate = contract.Date.AddMonths(quota);
        double amount = _paymentService.Payment(baseAmount, quota);
        contract.AddPayment(new Payment(dueDate, amount));
      }
    }
  }
}