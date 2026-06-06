using System;
using System.Globalization;
/* Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
médio dos funcionários.

Exemplo

Dados do primeiro funcionário:
Nome: Carlos Silva
Salário: 6300.00
--------------------------------
Dados do segundo funcionário:
Nome: Ana Marques
Salário: 6700.00
--------------------------------
Salário médio = 6500.00
 */


class Exercicio02
{
    static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario();
        Funcionario f2 = new Funcionario();

        Console.WriteLine("Dados do primeiro funcionário:");
        Console.Write("Nome: ");
        f1.Nome = Console.ReadLine();
        Console.Write("Salário: ");
        f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();

        Console.WriteLine("Dados do segundo funcionário:");
        Console.Write("Nome: ");
        f2.Nome = Console.ReadLine();
        Console.Write("Salário: ");
        f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salarioMedio = (f1.Salario + f2.Salario) / 2.0;

        Console.WriteLine();
        Console.WriteLine("Salário médio = " +
            salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
    }
}