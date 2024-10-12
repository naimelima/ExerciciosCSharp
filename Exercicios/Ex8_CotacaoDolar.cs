using System;

namespace Exercicios.Iniciais
{
  public class Ex8_CotacaoDolar : IExercicios
  {
    double real;
    double cotacao;

    public void EntradaDados()
    {
      Console.WriteLine("Digite o valor em reais:");
      this.real = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a cotação do dólar:");
      this.cotacao = double.Parse(Console.ReadLine());
    }
    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.ConversaoDolar();
    }
    public void ConversaoDolar()
    {
      double dolar = this.real / this.cotacao;

      Console.WriteLine("O valor em dólar é de " + dolar);
    }
  }  
}