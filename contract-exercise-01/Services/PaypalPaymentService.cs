namespace Course.Services
{
  class PaypalPaymentService : IPaymentService
  {
    private const double monthlyInterest = 0.01;
    private const double paymentFee = 0.02;

    public double Payment(double amount, int quota)
    {
      return amount * (1 + monthlyInterest * quota) * (1 + paymentFee);
    }
  }
}