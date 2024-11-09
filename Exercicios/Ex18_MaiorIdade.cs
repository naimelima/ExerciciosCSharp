using System;

namespace Exercicios.Iniciais
{
  public class Ex18_MaiorIdade : IExercicios
  {
     int [] idade = new int[10];
     int contador = 0;

     public void EntradaDados()
    {
      Console.WriteLine("Digite 10 idades:");
      int idade;
      bool ehIdade = false;

      for(int i = 0; i < 10; i++)
      {
        Console.Write($"Idade {i + 1}: ");
        ehIdade = int.TryParse(Console.ReadLine(), out idade);

        if(ehIdade)
        {
          this.idade[i] = idade;
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
          this.InformarMaiorIdade();
        }

        public void InformarMaiorIdade()
        {
          for(int i = 0; i < 10; i++)
          {
            if(this.idade[i] >= 18)
            {
              contador++;
              Console.WriteLine($"Maior de idade {i + 1}: {this.idade[i]}");
            }
            else
            {
              Console.WriteLine($"Menor de idade {i + 1}: {this.idade[i]}");
            }
          }
        }
        
      
    
  }
}