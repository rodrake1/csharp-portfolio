namespace Course.Services
{
  interface IPaymentService
  {
    double Payment(double amount, int quota);
  }
}