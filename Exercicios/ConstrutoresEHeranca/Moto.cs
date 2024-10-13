using System;

namespace Exercicios.Construtores
{                    //Herança
  public class Moto : VeiculoBase
  {
    int cilindradas;
        
    public Moto(string nome, int qtdRodas,  int qtdPassageiros, double velocidadeMaxima, int qtdEixos) :
      base(nome, qtdRodas, qtdPassageiros, velocidadeMaxima, qtdEixos)
    {
      
    }

    //Propriedades
    public int Cilindradas
    { 
      get { return cilindradas; }
    }
    
    //Método
    public void Abastecer(int qtdLitros) 
    {
      this.AumentarCombustivel(qtdLitros);
      Console.WriteLine(this.Nome + " Abastecido com " + qtdLitros + " litros");
      Console.WriteLine(this.Nome + " Agora seu tanque tem " + this.QtdCombustivel + " litros");
    }    
  }
}