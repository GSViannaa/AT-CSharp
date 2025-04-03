

using System.Runtime.Serialization;
using Q_11;

public class Program
{

    public static void Main()
    {
        bool continuar = true;

        do
        {
            Console.WriteLine("\n1. Adicionar Contato \n2. Listar Contatos \n3. Sair");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":

                    AdicionarContato();

                    break;

                case "2":

                    EscolherFormatoEListar();

                    break;

                case "3":

                    Console.WriteLine("Adeus");
                    return;

                    break;

                default:

                    Console.WriteLine("Opção inválida");

                    break;

            }

        } while (continuar);


        static void AdicionarContato()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Número no formato (99 99999-9999):");
            string numero = Console.ReadLine();

            Console.WriteLine("E-mail");
            string email = Console.ReadLine();

            Contatos contato = new Contatos(nome, numero, email);

            contato.SalvarContato();

        }

     

        static void EscolherFormatoEListar()
        {
            List<Contatos> contatos = CarregarContatos();

            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado");
                return;
            }

            Console.WriteLine($"Escolha o formato de exibição: \n1. Markdown \n2. Tabela \n3. Texto Puro ");
            string escolha = Console.ReadLine();

            ContatoFormatter formatter = null;

            switch (escolha)
            {
                case "1":

                    formatter = new MarkdownFormatter();
                    break;

                case "2":

                    formatter = new TabelaFormatter();
                    break;

                case "3":

                    formatter = new RawTextFormatter();
                    break;

                default:

                    Console.WriteLine("Opção inválida");
                    break;
            }

            if (formatter != null)
            {
                formatter.ExibirContatos(contatos);
            }
           
        }

        static List<Contatos> CarregarContatos()
        {
            List<Contatos> contatos = new List<Contatos>();

            try
            {
                using (StreamReader sr = new StreamReader("contatos.txt"))
                {

                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(',');
                        if (dados.Length == 3)
                        {
                            contatos.Add(new Contatos(dados[0], dados[1], dados[2]));
                        }

                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao ler o arquivo");
            }

            return contatos;
        }

    }



}




