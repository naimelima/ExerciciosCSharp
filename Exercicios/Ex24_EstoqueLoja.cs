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
            Console.Write("Digite quantos produtos deseja cadastrar no estoque: ");
            int qtdProdutos = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdProdutos; i++)
            {
                Console.Write($"Digite o nome do {i + 1}º produto: ");
                string nomeProduto = Console.ReadLine();

                Console.Write($"Digite a quantidade em estoque do produto {nomeProduto}: ");
                int quantidade = int.Parse(Console.ReadLine());

                estoque.Add(i + 1, new Estoque { NomeProduto = nomeProduto, Quantidade = quantidade });
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
            foreach (var produto in estoque)
            {
                Console.WriteLine($"Código: {produto.Key} - Produto: {produto.Value.NomeProduto}");
            }

            Console.Write("Digite o código do produto que deseja consultar o estoque: ");
            if (int.TryParse(Console.ReadLine(), out int codProduto))
            {
                if (estoque.TryGetValue(codProduto, out Estoque produtoEncontrado))
                {
                    Console.WriteLine($"O estoque do produto {produtoEncontrado.NomeProduto} é: {produtoEncontrado.Quantidade}");
                }
                else
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Código de produto inválido.");
            }
        }
   }

   public class Estoque
   {
      public string NomeProduto { get; set; }
      public int Quantidade { get; set; }
   }
}