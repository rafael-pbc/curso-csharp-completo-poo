using System;
/* Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
exemplo.

Exemplos:

Entrada             Saída
8                   MUITO OBRIGADO
-------------------------------------
Entrada             Saída
1                   Alcool: 1
-------------------------------------
Entrada             Saída
7                   Gasolina: 2
-------------------------------------
Entrada             Saída
2                   Diesel: 0
-------------------------------------
Entrada             Saída
2                   
-------------------------------------
Entrada             Saída
4              
-------------------------------------
 */

class Exercicio03
{
    static void Main(string[] args)
    {
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;

        while (true)
        {
            int codigo = int.Parse(Console.ReadLine());

            if (codigo == 4)
            {
                break;
            }

            if (codigo == 1)
            {
                alcool++;
            }
            else if (codigo == 2)
            {
                gasolina++;
            }
            else if (codigo == 3)
            {
                diesel++;
            }
            // Códigos inválidos são ignorados
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);
    }
}