/*
 * Fazer um programa para ler os dados de N produtos (N fornecido pelo usuário). 
Ao final, mostrar a etiqueta de preço de cada produto na
mesma ordem em que foram digitados. Todo produto possui nome e preço. Produtos
importados possuem uma taxa de alfândega, e produtos usados possuem data de fabricação.
Estes dados específicos devem ser acrescentados na etiqueta de preço conforme
exemplo (próxima página). Para produtos importados, a taxa e alfândega deve ser
acrescentada ao preço final do produto. Favor implementar o programa conforme projeto ao lado.

Exemplo

Enter the number of products: 3
Product #1 data:
Common, used or imported (c/u/i)? i
Name: Tablet
Price: 260.00
Customs fee: 20.00
Product #2 data:
Common, used or imported (c/u/i)? c
Name: Notebook
Price: 1100.00
Product #3 data:
Common, used or imported (c/u/i)? u
Name: Iphone
Price: 400.00
Manufacture date (DD/MM/YYYY): 15/03/2017
PRICE TAGS:
Tablet $ 280.00 (Customs fee: $ 20.00)
Notebook $ 1100.00
Iphone (used) $ 400.00 (Manufacture date: 15/03/2017
 */
using System.Globalization;

namespace SistemaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            // Criamos uma lista do tipo genérico da classe pai
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    // Adiciona o produto importado na lista de produtos comuns
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    // Adiciona o produto usado na lista de produtos comuns
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    // Adiciona o produto comum
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            // O Polimorfismo em ação: mesmo tratando todos como 'Product', 
            // o C# executa o PriceTag() específico de cada tipo real do objeto.
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}