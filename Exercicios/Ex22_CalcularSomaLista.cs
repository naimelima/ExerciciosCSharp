using System;
using System.Collections.Generic;
using System.Linq;
namespace Exercicios.Iniciais
{
   public class Ex22_CalcularSomaLista : IExercicios
  {
    List<int> listaNumeros = new List<int>();
    int numero;
  
    public void EntradaDados()
    {
      while (true)
      {
        Console.Write("Digite um número inteiro positivo, e digite 0 para finalizar o registro:");
        this.numero = int.Parse(Console.ReadLine());

        if (this.numero == 0)
        {
          break;
        }
            
          listaNumeros.Add(numero);
        
      }        
    }

    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.CalcularSoma();
    }

    public void CalcularSoma()
    {
      int soma = listaNumeros.Sum();
      //foreach (int numeros in this.listaNumeros)
      // {
      //    soma = + numeros;
      // }

       Console.WriteLine($"\nA soma dos números inseridos é: {soma}");
    }
  }
}