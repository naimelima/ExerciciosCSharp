using System;
using Exercicios.Iniciais;

namespace Exercicios.Loop
{
  public class ExForeach : IExercicios
  {
    public char [] letras = new char[10];
    
    public void EntradaDados()
    {
      Console.WriteLine("Digite 10 letras:");
      char letra;
      bool ehLetra = false;

      for (int i = 0; i < 10; i++)
      {
        Console.Write($"Letra {i + 1}: ");

        ehLetra = char.TryParse(Console.ReadLine(), out letra);

        if (ehLetra)
        {
          letras[i] = letra;
        }
        else
        {
          Console.WriteLine("ERRO: Digite uma letra válida!");
          i--;
        }        
      }
    }

    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.VerificarExistenciaVogal();
    }

    public void VerificarExistenciaVogal()
    {
      int contador = 0;
      foreach(char letra in letras)  
      {
        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
        {          
          Console.WriteLine("A letra " + letra + " é uma vogal");
          contador++;
        }
      }

      Console.WriteLine($"Quantidade de vogais é: {contador}");      
    }     
  }  
}