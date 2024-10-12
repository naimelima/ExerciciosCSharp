using System;

namespace Exercicios.Iniciais
{
  public class Ex9_RendimentoDeposito : IExercicios
  {
    double deposito;
    double rendimento;  
  
    public void EntradaDados()
    {
      Console.WriteLine("Digite o valor do depósito:");
      this.deposito = double.Parse(Console.ReadLine());
      
    }
    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.CalcularRendimento();
    }
    public void CalcularRendimento()
    {
      double rendimento = this.deposito * 0.007;
      double saldo = this.deposito + rendimento;

      Console.WriteLine("O rendimento é de R$ " + saldo);
    }
  }  
}

