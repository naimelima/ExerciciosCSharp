using System;

namespace Exercicios.Iniciais
{
    public class Ex6_TrocaVariavel
  {
    public void TrocaVariavel(int a, int b)
    {
      int aux = a;
      a = b;
      b = aux;
    
      Console.WriteLine("A = " + a + " e B = " + b); 
    }
  }




}