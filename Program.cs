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
                escritorArquivo.WriteLine(prod.Nome + "," + prod.Preco.ToString("f2", CultureInfo.InvariantCulture)+","+prod.Qtd.ToString());

            }

            Console.WriteLine();
            StreamReader leitor = new StreamReader(@"c:\tmp\csc\ItensVendidos.csv");
            string line = leitor.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = leitor.ReadLine();
            }
            leitor.Close();

            /* ---------------------------------   */

            String diretorioFonte2 = @"c:\tmp\csc";
            string diretorioDestino2 = diretorioFonte2 + @"\destino";
            string arquivoDestino2 = diretorioDestino2 + @"\Resumo.csv";

            using (StreamWriter escritorArquivo2 = File.AppendText(arquivoDestino2))
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("nome : ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Preco : ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Quantidade : ");
                    int qtd = int.Parse(Console.ReadLine());
                    Produto prod = new Produto(nome, preco, qtd);
                    escritorArquivo2.WriteLine(prod.Nome + "," + prod.Preco.ToString("f2", CultureInfo.InvariantCulture) + "," + prod.Qtd.ToString());

                }




        }












    }
}
