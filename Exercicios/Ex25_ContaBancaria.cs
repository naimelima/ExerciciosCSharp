using System;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace Exercicios.Iniciais
{
    public class Ex25_ContaBancaria : IExercicios
    {
        string usuario;
        string titular;
        double saldo;
        string senha;

        public void EntradaDados()
        {
            this.usuario = "Carlos123";
            this.titular = "Carlos Eduardo Soares";
            this.saldo = 20000;
            this.senha = "ReDaPu";
        }

        public void ExecutarExercicio()
        {
            this.EntradaDados();
            this.ContaBancaria();
        }

        public void ContaBancaria()
        {
            Console.WriteLine($"Usuário da conta: {this.usuario}");
            Console.WriteLine($"titular da conta: {this.titular}");
            Console.WriteLine($"Saldo da conta: {this.saldo}"); 
            Console.WriteLine($"Senha da conta: {this.senha}");
        }

    }
}