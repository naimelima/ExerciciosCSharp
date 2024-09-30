using System;

namespace Exercicios.Iniciais
{
  public class Ex4_RelatorioVendas : IExercicios 
  {
    //campos / fields
    string nomevendedor;
    double salariofixo;
    double totalvendas;

    //Métodos do contrato/interface/obrigatório
    public void EntradaDados()
    {
      Console.WriteLine("Digite o nome do vendedor:");
      this.nomevendedor = Console.ReadLine();
      Console.WriteLine("Digite o salário fixo:");
      this.salariofixo = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o total de vendas:");
      this.totalvendas = int.Parse(Console.ReadLine());      
    }

    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.CalcularSalarioVendedor();
    }

    //Metodos classe
    public void CalcularSalarioVendedor()
    {
      double salariofinal = this.salariofixo + (this.totalvendas * 0.15);
  
      Console.WriteLine("O salário final do vendedor " + nomevendedor     
        + " é de R$ " + salariofinal);
    }    
  }
}