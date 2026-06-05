using System;
using System.Globalization;
/* Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
situação

      y
      |
   Q2 | Q1
------|------x
   Q3 | Q4
      |

Exemplos:

Entrada             Saída
4.5 -2.2            Q4
-------------------------------------
Entrada             Saída
0.1 0.1             Q1
-------------------------------------
Entrada             Saída
0.0 0.0             Origem
-------------------------------------
 */

class Exercicio07
{
    static void Main()
    {
        double valorX, valorY;

        Console.Write("Digite O valor X: ");
        valorX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite O valor Y: ");
        valorY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (valorX == 0.0 && valorY == 0.0)
        {
            Console.WriteLine("Origem");
        }
        else if (valorX == 0.0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (valorY == 0.0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (valorX > 0.0 && valorY > 0.0)
        {
            Console.WriteLine("Q1");
        }
        else if (valorX < 0.0 && valorY > 0.0)
        {
            Console.WriteLine("Q2");
        }
        else if (valorX < 0.0 && valorY < 0.0)
        {
            Console.WriteLine("Q3");
        }
        else
        {
            Console.WriteLine("Q4");
        }
    }

}