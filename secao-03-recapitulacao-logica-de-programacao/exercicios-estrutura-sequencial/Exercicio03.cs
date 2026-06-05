using System;
/* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

Exemplos:

Entrada             Saída
5                   DIFERENCA = -26
6
7
8
------------------------------------
Entrada             Saída
5                   DIFERENCA = 86 
6
-7
8
------------------------------------
 */

class Exercicio03
{
    static void Main()
    {
        int valorA, valorB, valorC, valorD, diferenca;

        Console.Write("Digite o primeiro valor: ");
        valorA = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        valorB = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro valor: ");
        valorC = int.Parse(Console.ReadLine());

        Console.Write("Digite o quarto valor: ");
        valorD = int.Parse(Console.ReadLine());

        diferenca = valorA * valorB - valorC * valorD;

        Console.WriteLine("Resultado da diferença = " + diferenca);
    }
}