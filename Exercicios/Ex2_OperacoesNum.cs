using System;

namespace Exercicios.Iniciais
{
  public class Ex2_OperacoesNum : IExercicios
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
      this.OperacoesNum();
    }

    public void OperacoesNum()
    {
    int soma = this.num1 + this.num2;
    int subtracao = this.num1 - this.num2;
    int multiplicacao = this.num1 * this.num2;
    int divisao = this.num1 / this.num2;

    Console.WriteLine($"A soma é {soma}");
    Console.WriteLine($"A subtração é {subtracao}");
    Console.WriteLine($"A multiplicação é {multiplicacao}");
    Console.WriteLine($"A divisão {divisao}"); 
    }
  }  
}