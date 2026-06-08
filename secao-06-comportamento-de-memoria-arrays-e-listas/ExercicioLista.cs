using System;
using System.Globalization;
/* Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.
 
EXEMPLO 

How many employees will be registered? 3
Emplyoee #1:
Id: 333
Name: Maria Brown
Salary: 4000.00
Emplyoee #2:
Id: 536
Name: Alex Grey
Salary: 3000.00
Emplyoee #3:
Id: 772
Name: Bob Green
Salary: 5000.00
Enter the employee id that will have salary increase : 536
Enter the percentage: 10.0
Updated list of employees:
333, Maria Brown, 4000.00
536, Alex Grey, 3300.00
772, Bob Green, 5000.00

*/

class ExercicioLista
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        Console.Write("How many employees will be registered? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Employee #{i}:");

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            while (employees.Exists(x => x.Id == id))
            {
                Console.Write("Id already taken! Try again: ");
                id = int.Parse(Console.ReadLine());
            }

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Salary: ");
            double salary = double.Parse(
                Console.ReadLine(),
                CultureInfo.InvariantCulture);

            employees.Add(new Employee(id, name, salary));
        }

        Console.WriteLine();

        Console.Write("Enter the employee id that will have salary increase: ");
        int searchId = int.Parse(Console.ReadLine());

        Employee emp = employees.Find(x => x.Id == searchId);

        if (emp != null)
        {
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(
                Console.ReadLine(),
                CultureInfo.InvariantCulture);

            emp.IncreaseSalary(percentage);
        }
        else
        {
            Console.WriteLine("This id does not exist!");
        }

        Console.WriteLine();
        Console.WriteLine("Updated list of employees:");

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}