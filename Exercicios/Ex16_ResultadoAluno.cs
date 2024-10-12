using System;

namespace Exercicios.Iniciais
{
  public class Ex16_ResultadoAluno : IExercicios
  {
    double nota1;
    double nota2;
    double nota3;

    public void EntradaDados()
    {
      Console.WriteLine("Digite a primeira nota:");
      this.nota1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a segunda nota:");
      this.nota2 = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a terceira nota:");
      this.nota3 = double.Parse(Console.ReadLine());
    }
    
    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.CalcularMedia();
    }

    public void CalcularMedia()
    {
      double media = (this.nota1 + this.nota2 + this.nota3) / 3;

      if (media >= 7)
      {
        Console.WriteLine("O aluno foi aprovado");
      }
      else if (media >= 5 && media < 7)
      {
        Console.WriteLine("O aluno está de recuperação");
      }
      else 
      {
        Console.WriteLine("O aluno foi reprovado");
      }
    }
        
  }
}