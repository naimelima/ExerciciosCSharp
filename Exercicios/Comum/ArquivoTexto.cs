using System;
using System.IO;
using System.Collections.Generic;

namespace Exercicios.Comum
{
  public class ArquivoTexto
  {
    public string CaminhoArquivo { get; set; }
    
    public ArquivoTexto(string caminho, string nomeArquivo)
    {
      this.CaminhoArquivo = caminho + "/" + nomeArquivo;
    }

    public void GravarDadosEmArquivo(string texto)
    {
      if (!File.Exists(this.CaminhoArquivo))
      {
          // Cria o arquivo
          File.Create(this.CaminhoArquivo).Close();
          Console.WriteLine("Arquivo criado com sucesso.");
      }

      using (StreamWriter sw = new StreamWriter(this.CaminhoArquivo, true))
      {
          // Escreve os dados no arquivo, formatando a saída
          sw.WriteLine(texto);
      }      
    }

    public List<string> LerDadosDoArquivo()
    {

      List<string> lista = new List<string>();
      
      try
      {
          // Verifica se o arquivo existe
          if (File.Exists(this.CaminhoArquivo))
          {
              using (StreamReader sr = new StreamReader(this.CaminhoArquivo))
              {
                  string linha;                  

                  while ((linha = sr.ReadLine()) != null)
                  {
                    lista.Add(linha);
                  }
              }
          }
          else
          {
              Console.WriteLine("Arquivo não encontrado.");
          }
      }
      catch (IOException e)
      {
          Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
      }

      return lista;
      
    }


    
    
  }
}