using System;

namespace Exercicios.Iniciais
{
  public class Ex3_ConsumoMedio : IExercicios
  {
    double distancia; 
    double litros;

    public void EntradaDados()
    {
      Console.WriteLine("Digite a distância percorrida:");
      this.distancia = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a quantidade de litros consumidos:");
      this.litros = double.Parse(Console.ReadLine());
    }

    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.ConsumoMedio();
    }

    public void ConsumoMedio()
    {
      double consumoMedio = this.distancia / this.litros;

      Console.WriteLine("O consumo médio é de " + consumoMedio + " km/l");
    }
  } 
}