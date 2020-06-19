namespace Course.Entities
{
  class Company : TaxPayer
  {
    public int Employees { get; set; }

    public Company (string name, double anualIncome, int employees) : base(name, anualIncome)
    {
      Employees = employees;
    }

    public override double TaxesPaid()
    {
      double tax = Employees > 10 ? 0.14 : 0.16;
      return AnualIncome * tax;
    }
  }
}