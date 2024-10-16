using System;

namespace Exercicios.Iniciais
{
  public class Ex19_NomeSexo : IExercicios
  {
    string[] nome = new string[10];
    char[] sexos = new char[10];
    int totalHomens = 0;
    int totalMulheres = 0;
    int contador = 0;

    public void EntradaDados()
    {
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine("Digite o nome da pessoa {0}: ", i + 1);
        nome[i] = Console.ReadLine();
      
        Console.WriteLine("Digite o sexo da pessoa (M para masculino, F para feminino):");
        sexos[i] = char.Parse(Console.ReadLine());    
      }
    }
    
    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.InformarNomeSexo();
    }

    public void InformarNomeSexo()
    {
      for(int i = 0; i < 10; i++)
      {
        if (this.sexos[i] == 'F')
        {
          totalMulheres++;
        }
        else if (this.sexos[i] == 'M')
        {
          totalHomens++;
        }
      }
      for(int i = 0; i < 10; i++)
      {
        string sexo = (this.sexos[i] == 'M') ? "masculino" : "feminino";
        Console.WriteLine("Nome: {0} - Sexo: {1}", nome[i], sexo);
      }
        Console.WriteLine("Total de homens: {0}", totalHomens);
        Console.WriteLine("Total de mulheres: {0}", totalMulheres);
    }
  }
}