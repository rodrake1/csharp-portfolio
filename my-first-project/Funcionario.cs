using System.Globalization;

namespace my_first_project
{
  class Funcionario
  {
    public string Nome;
    public double Salario, Imposto;

    public double SalarioLiquido()
    {
      return Salario - Imposto;
    }

    public void AumentarSalario(double porcentagem)
    {
      Salario *= 1 + 1 / porcentagem;
    }

    public override string ToString()
    {
      return $"{Nome}, $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}