using System;
/* Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

Exemplos:

Entrada             Saída
2200                Senha Inválida
-------------------------------------
Entrada             Saída
1020                Senha Inválida
-------------------------------------
Entrada             Saída
2022                Senha Inválida
-------------------------------------
Entrada             Saída
2002                Acesso Permitido
-------------------------------------
 */

class Exercicio01
{
    static void Main()
    {
        {
            int senha;

            while (true)
            {
                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());

                if (senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }

    }
}