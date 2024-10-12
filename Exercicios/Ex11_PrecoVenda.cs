using System;

namespace Exercicios.Iniciais
{
  public class Ex11_PrecoVenda : IExercicios
  {
    double precocusto;
    double percentualacrescimo;

    public void EntradaDados()
    {
      Console.WriteLine("Digite o preço de custo:");
      this.precocusto = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite o percentual de acréscimo:");
      this.percentualacrescimo = double.Parse(Console.ReadLine());  
    }  
    public void ExecutarExercicio()
     {
       this.EntradaDados();
       this.CalcularPrecoVenda();
     }
    public void CalcularPrecoVenda()
     {
       double precovenda = this.precocusto * (1 + this.percentualacrescimo / 100);

       Console.WriteLine("O preço de venda é de R$ " + precovenda);
     }
  }
}