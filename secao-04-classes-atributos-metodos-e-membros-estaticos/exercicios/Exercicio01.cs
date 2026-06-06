using System;
/* Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
velha.

Exemplo

Dados da primeira pessoa:
Nome: Maria
Idade: 17
---------------------------
Dados da segunda pessoa:
Nome: Joao
Idade: 16
---------------------------
Pessoa mais velha: Maria
 */

class Exercicio01
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa();

        Console.Write("Nome da primeira pessoa: ");
        p1.Nome = Console.ReadLine();

        Console.Write("Idade da primeira pessoa: ");
        p1.Idade = int.Parse(Console.ReadLine());

        Console.Write("Nome da segunda pessoa: ");
        p2.Nome = Console.ReadLine();

        Console.Write("Idade da segunda pessoa: ");
        p2.Idade = int.Parse(Console.ReadLine());

        if (p1.Idade > p2.Idade)
            Console.WriteLine("Pessoa mais velha: " + p1.Nome);
        else
            Console.WriteLine("Pessoa mais velha: " + p2.Nome);
    }
}