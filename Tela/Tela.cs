using System;
using Exercicios.Loop;
using Exercicios.Construtores;

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
            for (int i = 0; i < quantidadeLinhas; i++)
            {
                Console.WriteLine();
            }
        }

        public void EscreverMenu()
        {
            Console.WriteLine("Lista de exercicios");
            this.EscreverLinhaVazia();
            Console.WriteLine("1 - Exercicio 1");
            Console.WriteLine("2 - Exercicio 2");
            Console.WriteLine("3 - Exercício 3");
            Console.WriteLine("4 - Exercício 4");
            Console.WriteLine("5 - Exercício 5");
            Console.WriteLine("6 - Exercício 6");
            Console.WriteLine("7 - Exercício 7");
            Console.WriteLine("8 - Exercício 8");
            Console.WriteLine("9 - Exercício 9");
            Console.WriteLine("10 - Exercício 10");
            Console.WriteLine("11 - Exercício 11");
            Console.WriteLine("12 - Exercício 12");
            Console.WriteLine("13 - Exercício 13");
            Console.WriteLine("14 - Exercício 14");
            Console.WriteLine("15 - Exercício 15");
            Console.WriteLine("16 - Exercício 16");
            Console.WriteLine("17 - Exercício 17");
            Console.WriteLine("100 - Loop - Foreach");
            Console.WriteLine("101 - Construtores - Veiculo");
        }

        public void LimparTela()
        {
            Console.Clear();
        }

        public void ExecutarExercicio(int numeroExercicio)
        {
            switch (numeroExercicio)
            {
                case 1:
                    var ex1 = new Ex1_ContaAdicao();
                    ex1.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 2:
                    var ex2 = new Ex2_OperacoesNum();
                    ex2.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 3:
                    var ex3 = new Ex3_ConsumoMedio();
                    ex3.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
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
                    var ex5 = new Ex5_NotasAluno();
                    ex5.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 6:
                    var ex6 = new Ex6_TrocaVariavel();
                    ex6.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 7:
                    var ex7 = new Ex7_ConversaoTem();
                    ex7.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 8:
                    var ex8 = new Ex8_CotacaoDolar();
                    ex8.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 9:
                    var ex9 = new Ex9_RendimentoDeposito();
                    ex9.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 10:
                    var ex10 = new Ex10_PrestacaoLoja();
                    ex10.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 11:
                    var ex11 = new Ex11_PrecoVenda();
                    ex11.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 12:
                    var ex12 = new Ex12_CustoCarro();
                    ex12.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 13:
                    var ex13 = new Ex13_MaiorNumero();
                    ex13.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 14:
                    var ex14 = new Ex14_MaiorValor();
                    ex14.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;

                case 15:
                    var ex15 = new Ex15_IntervaloNumero();
                    ex15.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 16:
                    var ex16 = new Ex16_ResultadoAluno();
                    ex16.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 17:
                    var ex17 = new Ex17_IntervaloLoop();
                    ex17.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 100:
                    var exForeach = new ExForeach();
                    exForeach.ExecutarExercicio();
                    this.EscreverLinhaVazia(3);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    this.LimparTela();
                    this.MontarTelaInicial();
                    break;
                case 101:                    
                    //var exConstrutores_Moto = new Veiculo(2, 2, 180, 2);
                    //exConstrutores_Moto.ExecutarExercicio();
                    //this.EscreverLinhaVazia(3);
                    //Console.WriteLine("Pressione qualquer tecla para continuar...");
                    //Console.ReadKey();
                    //this.LimparTela();
                    //this.MontarTelaInicial();
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