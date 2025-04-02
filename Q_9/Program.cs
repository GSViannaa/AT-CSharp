

using Q_9;

public class Program
{
    public static void Main()
    {
        Produtos[] produtos = new Produtos[5];
        int opcao;
        int quantidadeNaArray = 0;

        do
        {
            Console.WriteLine("\n1. Inserir Produto \n2. Listar Produto \n3. Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    AdicionarProdutos();

                    break;

                case 2:

                    ListarProdutos();

                    break;

                case 3:

                    Console.WriteLine("Adeus!");

                    break;

                default:

                    Console.WriteLine("Opção inválida");

                    break;
            }

        } while (opcao != 3);
            

        void AdicionarProdutos()
        {
            if (quantidadeNaArray < produtos.Length)
            {

                Console.WriteLine("Digite o nome do produto:");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a quantidade:");
                int quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o preço:");
                double preco = double.Parse(Console.ReadLine());

                Produtos produto = new Produtos(nome, quantidade, preco);
                produtos[quantidadeNaArray] = produto;
                quantidadeNaArray++;

            }
            else
            {
                Console.WriteLine("Limite de produtos atingido");

            }
        }
  

        void ListarProdutos()
        {
            if(quantidadeNaArray == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado");
            }
            else
            {
                for (int i = 0; i < quantidadeNaArray; i++)
                {
                    produtos[i].ExibirInformacoes();
                }
            }

        }

    }
}
