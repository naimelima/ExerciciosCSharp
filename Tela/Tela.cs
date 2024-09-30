using System;

namespace Exercicios.Iniciais
{
  public class Tela 
  {
    private string nomeSistema;

    // Construtor
    public Tela(string _nomeSistema)
    {
      this.nomeSistema = _nomeSistema;
    }

    //Métodos públicos
    public void EscreverLinha(string ponto, int tamanhoLinha = 43)
    {
      for (int i = 0; i < tamanhoLinha; i++)
      {
        Console.Write(ponto);
      }
    }

    public void EscreverNomeSistema()
    {
      Console.WriteLine(this.nomeSistema);
    }

    public void EscreverLinhaVazia(int quantidadeLinhas = 1)
    {
      for(int i = 0; i < quantidadeLinhas; i++)
      {
        Console.WriteLine();
      }
    }

    public void EscreverMenu()
    {
      Console.WriteLine("Lista de exercicios");
      this.EscreverLinhaVazia();
      Console.WriteLine("4 - Exercício 4");
      Console.WriteLine("5 - Exercício 5");
      Console.WriteLine("6 - Exercício 6");
    }

    public void LimparTela()
    {
      Console.Clear();
    }

    public void ExecutarExercicio(int numeroExercicio)
    {
      switch (numeroExercicio)
      {
      case 4:
              var ex4 = new Ex4_RelatorioVendas();
              ex4.ExecutarExercicio();
              this.EscreverLinhaVazia(3);
              Console.WriteLine("Pressione qualquer tecla para continuar...");
              Console.ReadKey();
              this.LimparTela();
              this.MontarTelaInicial();
              break;
      case 5:
              Console.WriteLine("Digite o nome do aluno:");
              string nomealuno = Console.ReadLine();
              Console.WriteLine("Digite a primeira nota:");
              int nota1 = int.Parse(Console.ReadLine());
              Console.WriteLine("Digite a segunda nota:");
              int nota2 = int.Parse(Console.ReadLine());
              Console.WriteLine("Digite a terceira nota:");
              int nota3 = int.Parse(Console.ReadLine());

              var ex5 = new Ex5_NotasAluno();

              ex5.NotasAluno(nomealuno, nota1, nota2, nota3);
              break;
      case 6:
              Console.WriteLine("Digite o valor de A:");
              int a = int.Parse(Console.ReadLine());
              Console.WriteLine("Digite o valor de B:");
              int b = int.Parse(Console.ReadLine());

              var ex6 = new Ex6_TrocaVariavel();

              ex6.TrocaVariavel(a, b);
              break;
          default:
              Console.WriteLine("Exercício não encontrado!");
              break;
      }
    }
    
    public void MontarTelaInicial()
    {
      this.EscreverLinha("=");
      this.EscreverLinhaVazia(2);      
      this.EscreverNomeSistema();
      this.EscreverLinhaVazia();
      this.EscreverLinha("=");

      this.EscreverMenu();
      this.EscreverLinhaVazia(2);

      Console.WriteLine("Digite o número do exercício desejado:");
      int numeroExercicio = int.Parse(Console.ReadLine());
      this.ExecutarExercicio(numeroExercicio);
      
      this.EscreverLinha("=");
    }

    
  }
}