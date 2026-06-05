using System;
/* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente.

Exemplos:

Entrada             Saída
6 24                São Múltiplos
------------------------------------
Entrada             Saída
6 25                Não são Múltiplos
------------------------------------
Entrada             Saída
24 6                São Múltiplos
 */

class Exercicio03
{
    static void Main()
    {
        int valorA, valorB;

        Console.Write("Digite o primeiro valor: ");
        valorA = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        valorB = int.Parse(Console.ReadLine());

        if (valorA  % valorB == 0 || valorB % valorA == 0)
        {

            Console.WriteLine("São Múltiplos");
        }
        else
        {
            Console.WriteLine("Não são Múltiplos");
        }
    }

}