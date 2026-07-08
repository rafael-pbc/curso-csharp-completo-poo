using System;
using System.Collections.Generic;
using System.IO;
/*
 Na contagem de votos de uma eleição, são gerados vários registrosde votação contendo o nome do candidato
e a quantidade de votos(formato .csv) que ele obteve em uma urna de votação. Você devefazer um programa para ler os
registros de votação a partir de umarquivo, e daí gerar um relatório consolidado com os totais de cadacandidato

input file:

Alex Blue,15
Maria Green,22
Bob Brown,21
Alex Blue,30
Bob Brown,15
Maria Green,27
Maria Green,22
Bob Brown,25
Alex Blue,31

Execution:
Enter file full path: c:\temp\in.txt
Alex Blue: 76
Maria Green: 71
Bob Brown: 61 
 */

namespace ConsolidadorVotos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            Dictionary<string, int> votacao = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] dados = line.Split(',');
                        string candidato = dados[0];
                        int votos = int.Parse(dados[1]);

                        if (votacao.ContainsKey(candidato))
                        {
                            votacao[candidato] += votos;
                        }
                        else
                        {
                            votacao[candidato] = votos;
                        }
                    }
                }

                foreach (KeyValuePair<string, int> item in votacao)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}