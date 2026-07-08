using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;


/* Fazer um programa para ler os dados (nome, email e salário)
de funcionários a partir de um arquivo em formato .csv.
Em seguida mostrar, em ordem alfabética, o email dos
funcionários cujo salário seja superior a um dado valor
fornecido pelo usuário.
Mostrar também a soma dos salários dos funcionários cujo
nome começa com a letra 'M'.
Veja exemplo na próxima página.
 
Input file:

Maria,maria@gmail.com,3200.00
Alex,alex@gmail.com,1900.00
Marco,marco@gmail.com,1700.00
Bob,bob@gmail.com,3500.00
Anna,anna@gmail.com,2800.00

Enter full file path: c:\temp\in.txt

Enter salary: 2000.00
Email of people whose salary is more than 2000.00:
anna@gmail.com
bob@gmail.com
maria@gmail.com
Sum of salary of people whose name starts with 'M': 4900.00

*/

namespace ConsultaFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double limitSalary = double.Parse(Console.ReadLine(), ci);

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], ci);

                        list.Add(new Employee(name, email, salary));
                    }
                }

                var emails = list.Where(e => e.Salary > limitSalary)
                                 .OrderBy(e => e.Email)
                                 .Select(e => e.Email);

                Console.WriteLine($"Email of people whose salary is more than {limitSalary.ToString("F2", ci)}:");
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }

                var sum = list.Where(e => e.Name.StartsWith("M"))
                              .Sum(e => e.Salary);

                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2", ci)}");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}