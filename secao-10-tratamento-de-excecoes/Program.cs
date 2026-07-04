using ExecucaoConta.Entities;
using ExecucaoConta.Entities.Exceptions;
using System.Globalization;

/* Fazer um programa para ler os dados de uma conta bancária e depois realizar um
saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
saque da conta. Implemente a conta bancária conforme projeto abaixo:
 
EXEMPLOS

Enter account data
Number: 8021
Holder: Bob Brown
Initial balance: 500.00
Withdraw limit: 300.00
Enter amount for withdr

Enter account data
Number: 8021
Holder: Bob Brown
Initial balance: 500.00
Withdraw limit: 300.00
Enter amount for withdraw: 400.00
Withdraw error: The amount exceeds withdraw limit

Enter account data
Number: 8021
Holder: Bob Brown
Initial balance: 500.00
Withdraw limit: 300.00
Enter amount for withdraw: 800.00
Withdraw error: The amount exceeds withdraw limit

Enter account data
Number: 8021
Holder: Bob Brown
Initial balance: 200.00
Withdraw limit: 300.00
Enter amount for withdraw: 250.00
Withdraw error: Not enough balance

*/

namespace ExecucaoConta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuração para aceitar o ponto (.) como separador decimal
            CultureInfo CI = CultureInfo.InvariantCulture;

            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CI);

                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CI);

                // Instanciação da conta
                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CI);

                // Tentativa de saque
                acc.Withdraw(amount);
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CI));
            }
            catch (DomainException e)
            {
                // Captura erros de regra de negócio (saldo insuficiente ou limite excedido)
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException)
            {
                // Captura erros caso o usuário digite letras onde deveriam ser números
                Console.WriteLine("Format error: Invalid input data.");
            }
            catch (Exception e)
            {
                // Captura qualquer outro erro inesperado
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}