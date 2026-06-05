using System;
using System.Globalization;
/* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159

Exemplos:

Entrada             Saída
2.00                A = 12.5664 
------------------------------------
Entrada             Saída
100.64              A = 31819.3103 
------------------------------------
Entrada             Saída
150.00              A = 70685.7750
------------------------------------
 */

class Exercicio02
{
    static void Main()
    {
        double raio, area;
        double pi = 3.14159;


        Console.Write("Digite o raio: ");
        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        area = pi * raio * raio;
        Console.WriteLine("Resultado da area = " + area.ToString("F4", CultureInfo.InvariantCulture));
    }
}