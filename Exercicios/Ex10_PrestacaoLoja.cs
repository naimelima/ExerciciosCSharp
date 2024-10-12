using System;

namespace Exercicios.Iniciais
{
  public class Ex10_PrestacaoLoja : IExercicios
  {
    double valorcompra;
    int parcelas;
  
    public void EntradaDados()
    {
      Console.WriteLine("Digite o valor da compra:");
      this.valorcompra = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite o número de parcelas:");
      this.parcelas = int.Parse(Console.ReadLine());
    }
    
    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.CalcularPrestacao();
    }

    public void CalcularPrestacao()
    {
      double prestacao = this.valorcompra / this.parcelas;

      Console.WriteLine("O valor da prestação é de R$ " + prestacao);
    }
  }
}