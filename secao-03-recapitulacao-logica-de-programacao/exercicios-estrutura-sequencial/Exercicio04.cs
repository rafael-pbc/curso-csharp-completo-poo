using System;
using System.Globalization;
/* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais.

Exemplos:

Entrada             Saída
25                  NUMBER = 25
100                 SALARY = U$ 550.00
5.50
------------------------------------
Entrada             Saída
1                   NUMBER = 1
200                 SALARY = U$ 4100.00
20.50
------------------------------------
Entrada             Saída
6                   NUMBER = 25
145                 SALARY = U$ 2254.75
15.55
------------------------------------
 */

class Exercicio04
{
    static void Main()
    {
        int numeroFuncionario, horasTrabalhadas;
        double valorPorHora, salario;

        Console.Write("Digite o número do funcionário: ");
        numeroFuncionario = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de horas trabalhadas: ");
        horasTrabalhadas = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor por hora: ");
        valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        salario = horasTrabalhadas * valorPorHora;

        Console.WriteLine("NUMBER = " + numeroFuncionario);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
    }
}