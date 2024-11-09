using System;
using System.Collections.Generic;
using Exercicios.Comum;

namespace Exercicios.Iniciais
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, char sexo, int idade)
        {
            this.Nome = nome;
            this.Sexo = sexo;
            this.Idade = idade;
        }
    }

    public class Ex19_NomeSexo : IExercicios
    {
        List<Pessoa> listaPessoas = new List<Pessoa>();


        int contador = 0;

        public void EntradaDados()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o nome da pessoa {0}: ", i + 1);
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o sexo da pessoa (M para masculino, F para feminino):");
                char sexo = char.Parse(Console.ReadLine());

                Console.WriteLine("Digite a idade da pessoa:");
                int idade = int.Parse(Console.ReadLine());

                listaPessoas.Add(new Pessoa(nome, sexo, idade));
            }
        }

        public void ExecutarExercicio()
        {
            this.EntradaDados();
            this.ImprimirResultado();
        }

        public void ImprimirResultado()
        {
            int totalHomens = 0;
            int totalMulheres = 0;

            foreach (Pessoa p in listaPessoas)
            {
                if (p.Sexo == 'F')
                {
                    totalMulheres++;
                }
                else if (p.Sexo == 'M')
                {
                    totalHomens++;
                }

              string sexo = (p.Sexo == 'M') ? "Masculino" : "Feminino";
                Console.WriteLine("Nome: {0} - Sexo: {1} - ", p.Nome, sexo, p.Idade);
            }

            Console.WriteLine("Total de homens: {0}", totalHomens);
            Console.WriteLine("Total de mulheres: {0}", totalMulheres);
        }
    }


}