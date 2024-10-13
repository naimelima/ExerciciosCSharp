using System;

namespace Exercicios.Iniciais
{
 
  public class Ex17_IntervaloLoop : IExercicios 
  {
    int [] numeros = new int[10];
    int contador = 0;
    
    
    public void EntradaDados()
    {
      Console.WriteLine("Digite 80 números inteiros:");
      int numero;
      bool ehNumero = false;
      
      
      for (int i = 0; i < 10; i++)
      {
        Console.Write($"Numero {i + 1}: ");
        
        ehNumero = int.TryParse(Console.ReadLine(), out numero);

        if (ehNumero)
        {
          numeros[i] = numero;
        }
        else
        {
          Console.WriteLine("ERRO: Digite um número válido!");
          i--;
        }        
      }
    }

    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.IntervaloLoop();
    }
    
    public void IntervaloLoop()
    {
      for (int i = 0; i < 10; i++)
      {
        if (numeros[i] >= 10 && numeros[i] <= 150)
        {
          contador++;
        }
      }
      Console.WriteLine($"Quantidade de números entre 10 e 150: {contador}");      
    }
  }
}