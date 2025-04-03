

using Q_9;

public class Program
{
    public static void Main()
    {
        Produtos[] produtos = new Produtos[5];
        string opcao;
        int quantidadeNaArray = 0;

        while (true)
        {
            Console.WriteLine("\n1. Inserir Produto \n2. Listar Produto \n3. Sair");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":

                    AdicionarProdutos();

                    break;

                case "2":

                    ListarProdutos();

                    break;

                case "3":

                    Console.WriteLine("Adeus!");
                    return;

                    break;

                default:

                    Console.WriteLine("Opção inválida");

                    break;
            }

        }             

        void AdicionarProdutos()
        {
            if (quantidadeNaArray < produtos.Length)
            {

                Console.WriteLine("Digite o nome do produto:");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a quantidade:");
                if (!int.TryParse(Console.ReadLine(), out int quantidade))
                {
                    Console.WriteLine("Quantidade inválida!");
                    return;
                }

                Console.WriteLine("Digite o preço:");
                if (!double.TryParse(Console.ReadLine(), out double preco))
                {
                    Console.WriteLine("Preço inválido!");
                    return;
                }

                Produtos produto = new Produtos(nome, quantidade, preco);
                produtos[quantidadeNaArray] = produto;
                quantidadeNaArray++;

                try
                {
                    using (StreamWriter sw = new StreamWriter("produtos.txt", true))
                    {
                        sw.WriteLine($"{nome},{quantidade},{preco}");

                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao salvar no arquivo: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Limite de produtos atingido");

            }
        }
  

        void ListarProdutos()
        {
            bool vazio = true;
            string linha;

            try
            {
                using (StreamReader sr = new StreamReader("produtos.txt"))
                {
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] produtosDados = linha.Split(',');

                        if (produtosDados.Length == 3)
                        {
                            Console.WriteLine($"Nome: {produtosDados[0]} | Quantidade: {produtosDados[1]} | Preço: {produtosDados[2]}");
                            vazio = false;
                        }
                        else
                        {
                            Console.WriteLine("Erro: Formato inválido no arquivo");
                        }
                    }
                    if (vazio)
                    {
                        Console.WriteLine("Nenhum produto cadastrado");
                    }
                    
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Nenhum produto cadastrado");
            }

            }

        }

    }



