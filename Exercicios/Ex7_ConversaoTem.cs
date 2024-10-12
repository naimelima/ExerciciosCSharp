using System;

namespace Exercicios.Iniciais
{
 public class Ex7_ConversaoTem : IExercicios
  {
    double celcius;
    double fahrenheit;

    public void EntradaDados()
    {
      Console.WriteLine("Digite a temperatura em Celcius:");
      this.celcius = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a temperatura em Fahrenheit:");
      this.fahrenheit = double.Parse(Console.ReadLine());
    }
    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.ConversaoTem();
    }
    public void ConversaoTem()
    {
      double fahrenheit = (9 * this.celcius + 160) / 5;

      Console.WriteLine("A temperatura em Fahrenheit é de " + fahrenheit);
    }
  }
}