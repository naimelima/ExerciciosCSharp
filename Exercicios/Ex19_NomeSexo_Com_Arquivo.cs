using System;
using System.Collections.Generic;
using Exercicios.Comum;

namespace Exercicios.Iniciais
{
   

    public class Ex19_NomeSexo_Com_Arquivo : IExercicios
    {
        
        ArquivoTexto arquivoDadosPessoa = new ArquivoTexto("./Arquivos/", "DadosPessoas.txt");
        int contador = 0;

        public void EntradaDados()
        {
            Console.WriteLine("Deseja incluir alguma pessoa (S/N): ");
            string incluirPessoa = Console.ReadLine();

            if(incluirPessoa == "S")
            {
                Console.WriteLine("Informe a quantidade pessoas: ");
                int quantidadePessoas = int.Parse(Console.ReadLine());

                for (int i = 0; i < quantidadePessoas; i++)
                {
                    Console.WriteLine("Digite o nome da pessoa {0}: ", i + 1);
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite o sexo da pessoa (M para masculino, F para feminino):");
                    char sexo = char.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a idade da pessoa:");
                    int idade = int.Parse(Console.ReadLine());

                    arquivoDadosPessoa.GravarDadosEmArquivo(nome + ";" + sexo + ";" + idade);                
                }
                
            }


            
            
        }

        public void ImprimirResultado()
        {
            int totalHomens = 0;
            int totalMulheres = 0;

            var listaDadosPessoas = arquivoDadosPessoa.LerDadosDoArquivo();

            foreach (var linha in listaDadosPessoas)
            {
                var dadosPessoa = linha.Split(";");

                if (dadosPessoa[1] == "M")
                {
                    totalHomens++;
                }
                else if (dadosPessoa[1] == "F")
                {
                    totalMulheres++;
                }

                Console.WriteLine("Nome: {0} - Sexo: {1} - Idade: {2}", dadosPessoa[0], dadosPessoa[1], dadosPessoa[2]);
            }
            
            Console.WriteLine("Total de homens: {0}", totalHomens);
            Console.WriteLine("Total de mulheres: {0}", totalMulheres);
        }
        

        public void ExecutarExercicio()
        {
            this.EntradaDados();
            this.ImprimirResultado();
        }

        
    }


}