namespace my_first_project
{
  class ConversorDeMoeda
  {
    public static double iof = 0.06;

    public static double DolarParaReal(double cotacao, double quantidade)
    {
      return cotacao * quantidade * (1 + iof);
    }
  }
}