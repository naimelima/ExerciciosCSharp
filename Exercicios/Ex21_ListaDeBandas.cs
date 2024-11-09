using System;
using System.Collections.Generic;
namespace Exercicios.Iniciais
{
  public class Ex21_ListaDeBandas : IExercicios
  {
    List<string> listaBandas = new List<string>();
    string nomeBanda;
    
   
    public void EntradaDados()
    {
      while (true)
      {
        Console.WriteLine("Digite o nome da banda, e digite FIM para finalizar o registro:");
        this.nomeBanda = Console.ReadLine();

        if (this.nomeBanda.ToUpper() == "FIM")
        {
          break;
        }
        
        listaBandas.Add(nomeBanda); 
      }                   
    }
      
    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.RegistrarBanda();
    }
      
    public void RegistrarBanda()
    {
       Console.WriteLine("\nLista das bandas armazenadas:");
       foreach (string banda in this.listaBandas)
       {
           Console.WriteLine(banda);
       }    
    }     
  }
}