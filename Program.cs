using System.Globalization;
using ExercicioProposto.Entities;
namespace ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            try
            {
                Console.Write("Informe o nome do arquivo ou sua extensão : ");
                string nomeArquivo = Console.ReadLine();

                var arquivos = from arquivo in Directory.EnumerateFiles(@"c:\tmp", "*.*")
                               where arquivo.ToLower().Contains(nomeArquivo)
                               select arquivo;

                foreach (var item in arquivos)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(arquivos.Count<string>().ToString() + " Encontrados");
            }

            catch (UnauthorizedAccessException UAEx)
            {
                Console.WriteLine(UAEx.Message);
            }

            catch (PathTooLongException PathEx)
            {
                Console.WriteLine(PathEx.Message);
            }


            //Alternativa do primeiro acima
          

            //    Console.WriteLine("Infome o nome ou o tipo de arquivo que você está procurando");
            //    string nomeArquivoTipo = Console.ReadLine();

            //    IEnumerable<string> arquivos = Directory.EnumerateFiles(@"c:\tmp", "*" + nomeArquivoTipo + "*", SearchOption.AllDirectories);
            //    Console.WriteLine("\n\rArquivos\n\r");
            //    foreach (var item in arquivos)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("\n\rOcorreu um erro\n\r" + e.Message);
            //}

            */




            String diretorioFonte1 = @"c:\tmp";

            string diretorioDestino1 = diretorioFonte1 + @"\csc";
            string arquivoDestino1 = diretorioDestino1 + @"\ItensVendidos.csv";

            Directory.CreateDirectory(diretorioDestino1);




            using (StreamWriter escritorArquivo = File.AppendText(arquivoDestino1))
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("nome : ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Preco : ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Quantidade : ");
                    int qtd = int.Parse(Console.ReadLine());
                    Produto prod = new Produto(nome, preco, qtd);
                    escritorArquivo.WriteLine(prod.Nome + "," + prod.Preco.ToString("f2", CultureInfo.InvariantCulture) + "," + prod.Qtd.ToString());

                }

            Console.WriteLine();
            StreamReader leitor1 = new StreamReader(@"c:\tmp\csc\ItensVendidos.csv");
            string line1 = leitor1.ReadLine();
            while (line1 != null)
            {
                Console.WriteLine(line1);
                line1 = leitor1.ReadLine();
            }
            leitor1.Close();

            /* ---------------------------------   */

            Console.Write("Informe o caminho e o nome do arquivo CSV: ");
            String arquivoFonte = Console.ReadLine();
            string[] linhas = File.ReadAllLines(arquivoFonte);

            String diretorioFonte2 = @"c:\tmp\csc";
            string diretorioDestino2 = diretorioFonte2 + @"\destino";
            string arquivoDestino2 = diretorioDestino2 + @"\resumo.csv";
            Directory.CreateDirectory(diretorioDestino2);

            using (StreamWriter escritorArquivo2 = File.AppendText(arquivoDestino2))
                foreach (var item in linhas)
                {
                    string[] campos = item.Split(',');
                    string nome = campos[0];
                    double preco = double.Parse(campos[1], CultureInfo.InvariantCulture);
                    int quantidade = int.Parse(campos[2]);

                    Produto prod = new Produto(nome, preco, quantidade);

                    escritorArquivo2.WriteLine(prod.Nome + "," + prod.Totalizar().ToString("f2", CultureInfo.InvariantCulture));
                }

            Console.WriteLine();
            StreamReader leitor2 = new StreamReader(@"c:\tmp\csc\destino\resumo.csv");
            string line2 = leitor2.ReadLine();
            while (line2 != null)
            {
                Console.WriteLine(line2);
                line2 = leitor2.ReadLine();
            }
            leitor2.Close();




        }

    }
}
