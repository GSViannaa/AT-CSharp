
    public  class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite a data atual (dd/mm/aaaa): ");
            string dataAtual = Console.ReadLine();

            DateTime dataAtualFormatada;
            DateTime dataFormatura = new DateTime(2028, 7, 15);


            if (DateTime.TryParse(dataAtual, out dataAtualFormatada))
            {
                TimeSpan diferenca = dataFormatura - dataAtualFormatada;
                int diasFaltam = diferenca.Days;

                if (dataAtualFormatada > dataFormatura)
                {
                    Console.WriteLine("\nParabéns! Você já deveria estar formado!");

                    return;
                }
                else
                {

                    int anos = diasFaltam / 365;
                    int meses = (diasFaltam % 365) / 30;
                    int dias = (diasFaltam % 365) % 30;

                    Console.WriteLine($"\nFaltam {anos} anos, {meses} meses e {dias} dias para a formatura!");


                    if (diferenca.Days <= 180)
                    {
                        Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
                    }


                }


            }
            else
            {
                Console.WriteLine("Data inválida");

            }

        }

    }
