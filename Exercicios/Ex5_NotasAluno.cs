using System;

namespace Exercicios.Iniciais
{
  public class Ex5_NotasAluno : IExercicios
  {
    string nomealuno; 
    int nota1;
    int nota2;
    int nota3;
    
     public void EntradaDados()
    {
      Console.WriteLine("Digite o nome do aluno:");
      string nomealuno = Console.ReadLine();
      Console.WriteLine("Digite a primeira nota:");
      this.nota1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite a segunda nota:");
      this.nota2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite a terceira nota:");
      this.nota3 = int.Parse(Console.ReadLine());
    }
      public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.NotasAluno();
    }
      public void NotasAluno()
    {
      double media = (this.nota1 + this.nota2 + this.nota3) / 2;

      Console.WriteLine("A média do aluno " + nomealuno + " é " + media);
     
    }
  }
}