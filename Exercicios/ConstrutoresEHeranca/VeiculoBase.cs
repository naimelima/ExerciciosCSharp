using System;
using Exercicios.Iniciais;

namespace Exercicios.Construtores
{
  public class VeiculoBase //: IExercicios
  {
      private int qtdRodas;
      private int qtdPortas;
      private int qtdPassageiros;
      private double velocidadeMaxima;
      private int qtdEixos;
      private int qtdCombustivel;
      private string nome;

      //Construtores devem ter o mesmo nome da classe
      public VeiculoBase(string nome, int qtdRodas,  int qtdPassageiros, double velocidadeMaxima, int qtdEixos):
        this(nome, qtdRodas, qtdPassageiros, velocidadeMaxima, qtdEixos, 0)
      {
        
      }
    
      public VeiculoBase(string nome, int qtdRodas,  int qtdPassageiros, double velocidadeMaxima, int qtdEixos, int qtdPortas)
      {
        this.nome = nome;
        this.qtdRodas = qtdRodas;
        this.qtdPassageiros = qtdPassageiros;
        this.velocidadeMaxima = velocidadeMaxima;
        this.qtdEixos = qtdEixos;
        this.qtdPortas = qtdPortas;
      }

      public int QtdRodas
      {
        get { return this.qtdRodas; }               
      }

    public int QtdCombustivel
    {
      get { return this.qtdCombustivel; }               
    }

    public string Nome
      {
        get { return this.nome; }               
      }

    public void AumentarCombustivel(int qtdLitros) 
    {
      this.qtdCombustivel += qtdLitros;     
    }
  } 
}