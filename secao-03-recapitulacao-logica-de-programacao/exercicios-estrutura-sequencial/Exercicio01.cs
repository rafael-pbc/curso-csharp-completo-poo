using System;
/*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
mensagem explicativa, conforme exemplos.
Exemplos:

Entrada             Saída
10                  SOMA = 40 
30
------------------------------------
Entrada             Saída
-30                 SOMA = -20 
10
------------------------------------
Entrada             Saída
0                   SOMA = 0 
0
------------------------------------
 */

class Exercicio01
{
    static void Main()
    {
        int valor1, valor2, soma;

        Console.Write("Digite o primeiro valor: ");
        valor1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        valor2 = int.Parse(Console.ReadLine());

        soma = valor1 + valor2;
        Console.WriteLine("Resultado da soma = " + soma);
    }
}