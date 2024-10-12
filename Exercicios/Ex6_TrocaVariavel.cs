using System;

namespace Exercicios.Iniciais
{
  public class Ex6_TrocaVariavel : IExercicios
  {
   int a;
   int b;

     public void EntradaDados()
    {
      Console.WriteLine("Digite o valor de A:");
      this.a = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o valor de B:");
      this.b = int.Parse(Console.ReadLine());
    }
    public void ExecutarExercicio()

    
    {
      this.EntradaDados();
      this.TrocaVariavel(); 
    }
    public void TrocaVariavel()
    {
      int aux = this.a;
      this.a = this.b;
      this.b = aux;
    
      Console.WriteLine("A = " + a + " e B = " + b); 
    }
  }
}