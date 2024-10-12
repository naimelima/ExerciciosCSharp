using System;

namespace Exercicios.Iniciais
{
  public class Ex13_MaiorNumero : IExercicios
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
      this.CalcularMaiorNumero();
    }

    public void CalcularMaiorNumero()
    {
      if (this.numero > 10)
      {
        Console.WriteLine("O número é maior que 10");   
      }    
    }  
  }  
}