using System;

namespace Exercicios.Iniciais
{
  public class Ex12_CustoCarro : IExercicios  
  {
    double custoFabrica;
    double porcentagemImpostos;
    double porcentagemDistribuidor;
    double impostosFabrica;
  
    public void EntradaDados()
    {
      Console.WriteLine("Digite o custo de fábrica do carro:");
      this.custoFabrica = double.Parse(Console.ReadLine());
    }

    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.CalcularCustoCarro();
    }
    
    public void CalcularCustoCarro()
    {
      this.porcentagemImpostos = this.custoFabrica * 0.45;
      this.impostosFabrica = this.custoFabrica + this.porcentagemImpostos;
      this.porcentagemDistribuidor = this.impostosFabrica * 0.28;
      double custoConsumidor = this.porcentagemDistribuidor + this.impostosFabrica;
    
      Console.WriteLine("O custo final do carro é de R$ " + custoConsumidor);            
    }
  }
}