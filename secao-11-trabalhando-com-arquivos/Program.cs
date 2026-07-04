using System.Globalization;

/* Fazer um programa para ler o caminho de um arquivo .csv
contendo os dados de itens vendidos. Cada item possui um
nome, preço unitário e quantidade, separados por vírgula. Você
deve gerar um novo arquivo chamado "summary.csv", localizado
em uma subpasta chamada "out" a partir da pasta original do
arquivo de origem, contendo apenas o nome e o valor total para
aquele item (preço unitário multiplicado pela quantidade),
conforme exemplo.
 
EXEMPLOS

Source file:
TV LED,1290.99,1
Video Game Chair,350.50,3
Iphone X,900.00,2
Samsung Galaxy 9,850.00,2

Output file (out/summary.csv):
TV LED,1290.99
Video Game Chair,1051.50
Iphone X,1800.00
Samsung Galaxy 9,1700.00

*/


namespace ProcessadorArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuração para garantir o uso do ponto (.) como separador decimal
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o caminho completo do arquivo .csv de origem: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                // Obtém o diretório do arquivo original (ex: C:\temp)
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);

                // Define o caminho da nova subpasta "out" (ex: C:\temp\out)
                string targetFolderPath = Path.Combine(sourceFolderPath, "out");

                // Define o caminho completo do arquivo de destino (ex: C:\temp\out\summary.csv)
                string targetFilePath = Path.Combine(targetFolderPath, "summary.csv");

                // Cria a pasta "out" caso ela ainda não exista
                Directory.CreateDirectory(targetFolderPath);

                // Abre o arquivo de origem para leitura e cria/sobrescreve o arquivo de destino para escrita
                using (StreamReader sr = File.OpenText(sourceFilePath))
                using (StreamWriter sw = File.CreateText(targetFilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        // Lê a linha atual do arquivo original
                        string line = sr.ReadLine();

                        // Divide os dados da linha usando a vírgula como separador
                        string[] fields = line.Split(',');

                        string name = fields[0];
                        double price = double.Parse(fields[1], CI);
                        int quantity = int.Parse(fields[2]);

                        // Calcula o valor total do item
                        double total = price * quantity;

                        // Escreve o nome e o total formatado no arquivo summary.csv
                        sw.WriteLine(name + "," + total.ToString("F2", CI));
                    }
                }

                Console.WriteLine("\nArquivo 'summary.csv' gerado com sucesso na pasta 'out'!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro de E/S (Input/Output): " + e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro de formatação: Verifique se os números e dados no CSV estão no formato correto.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro inesperado: " + e.Message);
            }
        }
    }
}