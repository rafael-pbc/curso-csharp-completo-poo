using System;
/* Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

Exemplos:

Entrada             Saída
2 2                 primeiro
-------------------------------------
Entrada             Saída
3 -2                quarto
-------------------------------------
Entrada             Saída
-8 -1               terceiro
-------------------------------------
Entrada             Saída
-7 1                segundo
-------------------------------------
Entrada             Saída
0 2               
-------------------------------------
 */

class Exercicio02
{
    static void Main()
    {
        while (true)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            if (x == 0 || y == 0)
            {
                break;
            }

            if (x > 0 && y > 0)
            {
                Console.WriteLine("primeiro");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("segundo");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("terceiro");
            }
            else
            {
                Console.WriteLine("quarto");
            }
        }

    }
}