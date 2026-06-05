using System;
/* Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

Exemplos:

Entrada             Saída
-12                 IMPAR
------------------------------------
Entrada             Saída
-27                 IMPAR
------------------------------------
Entrada             Saída
0                   PAR
 */

class Exercicio02
{
    static void Main()
    {
        int valor;

        Console.Write("Digite um valor inteiro: ");
        valor = int.Parse(Console.ReadLine());

       if(valor  % 2 == 0)
        {

            Console.WriteLine("PAR" );
        }
        else
        {
            Console.WriteLine("IMPAR");
        }
    }

}