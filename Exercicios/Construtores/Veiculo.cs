using System;
using Exercicios.Iniciais;

namespace Exercicios.Construtores
{
  public class Veiculo //: IExercicios
  {
      int qtdRodas;
      int qtdPortas;
      int qtdPassageiros;
      double velocidadeMaxima;
      int qtdEixos;

      public Veiculo(int qtdRodas,  int qtdPassageiros, double velocidadeMaxima, int qtdEixos):
        this(qtdRodas, qtdPassageiros, velocidadeMaxima, qtdEixos, 0)
      {
        
      }
    
      public Veiculo(int qtdRodas,  int qtdPassageiros, double velocidadeMaxima, int qtdEixos, int qtdPortas)
      {
        this.qtdRodas = qtdRodas;
        this.qtdPassageiros = qtdPassageiros;
        this.velocidadeMaxima = velocidadeMaxima;
        this.qtdEixos = qtdEixos;
        this.qtdPortas = qtdPortas;
      }    
  }
}