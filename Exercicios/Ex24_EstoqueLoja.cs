using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Exercicios.Iniciais
{
  public class Ex24_EstoqueLoja : IExercicios
  {
    Dictionary<int, Estoque> estoque = new Dictionary<int, Estoque>();

    public void EntradaDados()
    {
       Console.Write("Digite quantos produtos deseja cadastrar no estoque:");
       int qtdProdutos = int.Parse(Console.ReadLine());

       for(int i = 0; i < qtdProdutos; i++)
       {
          Estoque estoqueProduto = new Estoque(); 
          Console.Write($"Digite o nome do {i+1}º produto:");
          estoqueProduto.NomeProduto = Console.ReadLine();

          estoqueProduto.Estoque = new List<int>();
          for(int y = 0;  y < 1; y++)
          {
            Console.Write($"Informe a quantidade que contem no estoque do produto {estoqueProduto.NomeProduto}");
            int registrarQuantidade = int.Parse(Console.ReadLine());
            estoqueProduto.Estoque.Add(registrarQuantidade);
          }
          estoque.Add(i+1, estoqueProduto);
       }

    }

    public void ExecutarExercicio()
    {
        this.EntradaDados();
        this.EstoqueDeProdutos();
    }
    
    public void EstoqueDeProdutos()
    {
         Console.WriteLine("Lista de produtos cadastrados:");
         foreach(var estoqueProduto in estoque)
         {
            Console.WriteLine($"Código: {estoqueProduto.Key} Produto: {estoqueProduto.Value.Estoque}");
         }
         
         Console.Write($"Digite o código do produto que deseja exibir o estoque:");
         int codProduto = int.Parse(Console.ReadLine());

         if(estoque.ContainsKey(codProduto))
         {
            var produtoProcurado = estoque[codProduto];
            Console.WriteLine($"O estoque do produto {produtoProcurado.NomeProduto} é: {produtoProcurado.Estoque}");

         }
         else
         {
            Console.WriteLine("Produto não encontrado.");
         }
    }

  }

  public class Estoque
  {
    public string NomeProduto {get; set;}
    public List<int> Estoque {get; set;}
  }
}