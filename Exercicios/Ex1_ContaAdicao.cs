using System;

namespace Exercicios.Iniciais
{
  public class Ex1_ContaAdicao : IExercicios
  {
    int num1;
    int num2;

    public void EntradaDados()
    {
      Console.WriteLine("Digite o primeiro número:");
      this.num1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo número:");
      this.num2 = int.Parse(Console.ReadLine());
    }
    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.ContaAdicao();
    }

    public void ContaAdicao()
    {
      int soma = this.num1 + this.num2;

      Console.WriteLine("A soma é " + soma);
    }
  }
}