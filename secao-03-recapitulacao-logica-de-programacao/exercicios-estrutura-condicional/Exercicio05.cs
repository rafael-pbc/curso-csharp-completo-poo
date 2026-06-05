using System;
using System.Globalization;
/* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a pagar.

------------------------------------------------
CODIGO          ESPECIFICAÇÃO           PREÇO
------------------------------------------------
1               Cachorro Quente         R$ 4.00
2               X-Salada                R$ 4.50
3               X-Bacon                 R$ 5.00
4               Torrada Simples         R$ 2.00
5               Refrigerante            R$ 1.50
------------------------------------------------
Exemplos:

Entrada             Saída
3 2                 Total: R$ 10.00
------------------------------------
Entrada             Saída
2 3                 Total: R$ 13.50
------------------------------------
 */

class Exercicio05
{
    static void Main()
    {
        int codigoProduto, quantidade;
        double total = 0.0;

        Console.Write("Digite o código do produto: ");
        codigoProduto = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade: ");
        quantidade = int.Parse(Console.ReadLine());
        
        if (codigoProduto == 1)
        {
            total = quantidade * 4.0;
        }
        else if (codigoProduto == 2)
        {
            total = quantidade * 4.5;
        }
        if (codigoProduto == 3)
        {
            total = quantidade * 5.0;
        }
        if (codigoProduto == 4)
        {
            total = quantidade * 2.0;
        }
        else if (codigoProduto  == 5)
        {
            total = quantidade * 1.5;
        }
        else
        {
            Console.WriteLine("Código de produto inválido");
        }

        Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }

}