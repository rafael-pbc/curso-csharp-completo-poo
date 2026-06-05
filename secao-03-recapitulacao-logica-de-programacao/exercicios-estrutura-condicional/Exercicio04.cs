using System;
/* Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

Exemplos:

Entrada             Saída
16 2                O JOGO DUROU 10 HORA(S)
------------------------------------
Entrada             Saída
0 0                 O JOGO DUROU 24 HORA(S)
------------------------------------
Entrada             Saída
2 16                O JOGO DUROU 14 HORA(S)
 */

class Exercicio04
{
    static void Main()
    {
        int horaInicial, horaFinal, duracao;

        Console.Write("Digite a hora inicial: ");
        horaInicial = int.Parse(Console.ReadLine());

        Console.Write("Digite a hora final: ");
        horaFinal = int.Parse(Console.ReadLine());
        
        if (horaInicial < horaFinal)
        {
            duracao = horaFinal - horaInicial;
        }
        else if (horaInicial > horaFinal)
        {
            duracao = (24 - horaInicial) + horaFinal;
        }
        else
        {
            duracao = 24;
        }

        Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
    }

}