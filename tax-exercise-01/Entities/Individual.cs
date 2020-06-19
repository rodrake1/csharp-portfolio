namespace Course.Entities
{
  class Individual : TaxPayer
  {
    public double HealthExpenditures { get; set; }

    public Individual (string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
    {
      HealthExpenditures = healthExpenditures;
    }

    public override double TaxesPaid()
    {
      double tax = AnualIncome < 20000 ? 0.15 : 0.25;
      return AnualIncome * tax - HealthExpenditures * 0.5;
    }
  }
}