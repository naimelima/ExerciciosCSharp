using System;

namespace Exercicios.Iniciais
{
  public class Ex14_MaiorValor : IExercicios
  {
    int valor1;
    int valor2;

    public void EntradaDados()
    {
      Console.WriteLine("Digite o primeiro valor:");
      this.valor1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo valor:");
      this.valor2 = int.Parse(Console.ReadLine());
    }
    
    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.InformarMaiorValor();
    }
    public void InformarMaiorValor()
    {
      if (this.valor1 > this.valor2)
      {
        Console.WriteLine("O valor 1 é maior que o valor 2");
      }
      else if (this.valor2 > this.valor1)
      {
        Console.WriteLine("O valor 2 é maior que o valor 1");
      }
      else
      {
        Console.WriteLine("Os valores são iguais");
      }
    }
    
  }
  
}