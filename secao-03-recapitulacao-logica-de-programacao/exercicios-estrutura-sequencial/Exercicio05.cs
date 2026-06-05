using System;
using System.Globalization;
/* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

Exemplos:

Entrada             Saída
12 1 5.30           VALOR A PAGAR: R$ 15.50
16 2 5.10           
------------------------------------
Entrada             Saída
13 2 15.30          VALOR A PAGAR: R$ 51.40
161 4 5.20        
------------------------------------
Entrada             Saída
1 1 15.10           VALOR A PAGAR: R$ 30.20
2 1 15.10        
------------------------------------
 */

class Exercicio05
{
    static void Main()
    {
        int codigoPeca1, codigoPeca2, numeroPecas1, numeroPecas2;
        double valorUnitarioPeca1, valorUnitarioPeca2, totalPagar;

        Console.Write("Digite o código da primeira peça: ");
        codigoPeca1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de peças: ");
        numeroPecas1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor unitário: ");
        valorUnitarioPeca1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite o código da segunda peça: ");
        codigoPeca2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de peças: ");
        numeroPecas2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor unitário: ");
        valorUnitarioPeca2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        totalPagar = (numeroPecas1 * valorUnitarioPeca1) + (numeroPecas2 * valorUnitarioPeca2);

        Console.WriteLine("VALOR A PAGAR: R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
    }
}