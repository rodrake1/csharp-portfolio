using System;

namespace my_first_project
{
  class Retangulo
  {
    public double Largura, Altura;

    public double Area()
    {
      return Largura * Altura;
    }

    public double Perimetro()
    {
      return 2 * (Largura + Altura);
    }

    public double Diagonal()
    {
      return Math.Sqrt(Largura * Largura + Altura * Altura);
    }
  }
}