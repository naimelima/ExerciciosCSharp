using System;

namespace Exercicios.Iniciais
{
  public class Ex15_IntervaloNumero : IExercicios
  {
    int numero;

    public void EntradaDados()
    {
      Console.WriteLine("Digite um número:");
      this.numero = int.Parse(Console.ReadLine());
    }

    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.IntervaloNumero();
    }

    public void IntervaloNumero()
    {
      if (this.numero >= 100 && this.numero <= 200)
      {
        Console.WriteLine("O número está no intervalo entre 100 e 200");
      }
      else
      {
        Console.WriteLine("O número não está no intervalo entre 100 e 200");
      }
    }
    
  } 
}