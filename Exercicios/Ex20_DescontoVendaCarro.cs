using System;

namespace Exercicios.Iniciais
{
  public class Ex20_DescontoVendaCarro : IExercicios
  {
    int totalCarros2000OuMenos = 0;
    int totalCarros = 0;
    string continuar = "S";
    double desconto = 0;
    double precoCarro = 0;
    double anoCarro = 0;

    public void EntradaDados()
    {
      while (this.continuar.ToUpper() == "S")
      {
        Console.WriteLine("Digite o preço do carro:");
        double precoCarro = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o ano do carro:");
        int anoCarro = int.Parse(Console.ReadLine());


        

        Console.WriteLine("Deseja continuar?");
        this.continuar = Console.ReadLine();
      }
    }

    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.CalcularDesconto();
    }

    public void CalcularDesconto()
    {
      while(this.continuar.ToUpper() == "S")
      {
        if (this.anoCarro <= 2000)
        {
          this.desconto = this.precoCarro * 0.12;
          this.totalCarros2000OuMenos++;
        }
        else
        {
          this.desconto = this.precoCarro * 0.07;
        }
        
        double valorComDesconto = this.precoCarro - this.desconto;

        Console.WriteLine($"Desconto: R${this.desconto:F2}");
        Console.WriteLine($"Valor a ser pago: R${valorComDesconto:F2}");

        totalCarros++;        
      }  

        Console.WriteLine($"Total de carros com o ano até 2000           {this.totalCarros2000OuMenos}");
        Console.WriteLine($"Total de carros: {this.totalCarros}");
    }    
  }
}