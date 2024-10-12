using System;

namespace Exercicios.Iniciais
{
 
  public class Ex17_IntervaloLoop : IExercicios 
  {
    int [] numeros = new int[80];
    int contador = 0;
    
    public void EntradaDados()
    {
      Console.WriteLine("Digite 80 números inteiros:");
      
    }

    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.IntervaloLoop();
    }
    public void IntervaloLoop()
    {
      if (this.numero >= 10 && this.numero <= 150)
      {
        this.quantidadeNoIntervalo++;

      }

      Console.WriteLine("A quantidade de números no intervalo é de " + this.quantidadeNoIntervalo")
      
    }
  }
}