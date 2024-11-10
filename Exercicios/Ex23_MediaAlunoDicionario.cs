using System;
using System.Collections.Generic;
using System.Linq; 

namespace Exercicios.Iniciais
{
  public class Ex23_MediaAlunoDicionario : IExercicios
  {
    Dictionary<int, Aluno> alunos = new Dictionary<int, Aluno>();

    public void EntradaDados()
    {
      Console.Write("Quantos alunos você deseja cadastrar: ");
      int qtdAlunos = int.Parse(Console.ReadLine());

      for(int i = 0; i < qtdAlunos; i++)
      {
        Aluno aluno = new Aluno();
        Console.Write($"Informe o nome do {i+1}º aluno: ");
        aluno.Nome = Console.ReadLine();

        aluno.Notas = new List<int>();
        for(int j = 0; j < 4; j++)
        {
          Console.Write($"Informe a {j+1}ª nota do aluno {aluno.Nome}: ");
          int nota = int.Parse(Console.ReadLine());
          aluno.Notas.Add(nota);
        }

        alunos.Add(i+1, aluno);
      }
    }
    public void ExecutarExercicio()
    {
      this.EntradaDados();
      this.ExibirMedias(); 
    } 
    public void ExibirMedias()
    {
      Console.WriteLine("Lista de alunos cadastrados");
      foreach(var aluno in alunos)
      {
        Console.WriteLine($"Código: {aluno.Key} Nome: {aluno.Value.Nome}");
      }

      Console.Write("Digite o código do aluno que deseja exibir a média: ");
      int codAluno = int.Parse(Console.ReadLine());
      
      if(alunos.ContainsKey(codAluno))
      {
        var alunoProcurado = alunos[codAluno];
        Console.WriteLine($"A média do aluno {alunoProcurado.Nome} foi: {alunoProcurado.Notas.Average()}");
      }
      else
      {
        Console.WriteLine("Aluno não encontrado");
      }
    }     
  }

  public class Aluno
  {
    public string Nome {get; set;}
    public List<int> Notas {get; set;}
  }
}