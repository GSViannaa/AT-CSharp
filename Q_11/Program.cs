

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

                    ListarContatos();

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

        void ListarContatos()
        {
            bool vazio = true;
            string linha;

            try
            {
                using (StreamReader sr = new StreamReader("contatos.txt"))
                {
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] contatosDados = linha.Split(',');

                        if (contatosDados.Length == 3)
                        {
                            Console.WriteLine($"Nome: {contatosDados[0]} | Número: {contatosDados[1]} | E-mail: {contatosDados[2]}");
                            vazio = false;
                        }
                        else
                        {
                            Console.WriteLine("Erro: Formato inválido no arquivo.");
                        }
                    }
                    if (vazio)
                    {
                        Console.WriteLine("Nenhum contato cadastrado");
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Nenhum produto cadastrado.");
            }

        }

    }



}

    


