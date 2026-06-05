using System;
/* Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

Exemplos:

Entrada             Saída
-10                 NEGATIVO
------------------------------------
Entrada             Saída
8                   NÃO NEGATIVO
------------------------------------
Entrada             Saída
0                   NÃO NEGATIVO
 */

class Exercicio01
{
    static void Main()
    {
        int valor;

        Console.Write("Digite um valor inteiro: ");
        valor = int.Parse(Console.ReadLine());

       if(valor < 0)
        {

            Console.WriteLine("NEGATIVO" );
        }
        else
        {
            Console.WriteLine("NÃO NEGATIVO");
        }
    }

}