using System;
using System.Globalization;
/* Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
seguintes intervalos ([0,25], [25,50], [50,75], [75,100]) este valor se encontra. Obviamente se o valor não estiver em
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

Exemplos:

Entrada             Saída
25.01               Intervalo [25,50]
-------------------------------------
Entrada             Saída
25.00               Intervalo [0,25]
-------------------------------------
Entrada             Saída
100.00              Intervalo [75,100]
-------------------------------------
Entrada             Saída
-25.02              Fora de intervalo
-------------------------------------
 */

class Exercicio06
{
    static void Main()
    {
        double valor;

        Console.Write("Digite um valor: ");
        valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (valor >= 0.0 && valor <= 25.0)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (valor > 25.0 && valor <= 50.0)
        {
            Console.WriteLine("Intervalo [25,50]");
        }
        else if (valor > 50.0 && valor <= 75.0)
        {
            Console.WriteLine("Intervalo [50,75]");
        }
        else if (valor > 75.0 && valor <= 100.0)
        {
            Console.WriteLine("Intervalo [75,100]");
        }
        else
        {
            Console.WriteLine("Fora de intervalo");
        }
    }

}