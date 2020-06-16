namespace my_first_project
{
  class Aluno
  {
    public string Nome;
    public double Nota1, Nota2, Nota3, Media = 60;

    public double NotaFinal()
    {
      return Nota1 + Nota2 + Nota3;
    }

    public bool Aprovado()
    {
      return NotaFinal() >= Media ? true : false;
    }

    public double PontosFaltantes()
    {
      return Aprovado() ? 0 : Media - NotaFinal();
    }
  }
}