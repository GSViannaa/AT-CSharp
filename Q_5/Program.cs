

public class Program
{

    public static void Main()
    {

        Console.WriteLine("Digite sua data de nascimento (dd/mm/aaaa): ");
        string dataNascimento = Console.ReadLine();
        DateTime dataNascimentoFormatada;

        if (DateTime.TryParse(dataNascimento, out dataNascimentoFormatada))
        {

            dataNascimentoFormatada = CalcularAniversario(dataNascimentoFormatada);
            TimeSpan diferenca = dataNascimentoFormatada - DateTime.Now;

            if (diferenca.Days <= 7)
            {
                Console.WriteLine("Falta menso de uma semana para o seu aniversário!!!");

            }
            else
            {
                Console.WriteLine($"Faltam {diferenca.Days} dias para seu aniversário");
            }


        }
        else
        {
            Console.WriteLine("Data inválida");
        }

        static DateTime CalcularAniversario(DateTime dataNascimento)
        {

            int anoAtual = DateTime.Now.Year;
            DateTime aniversario = new DateTime(anoAtual, dataNascimento.Month, dataNascimento.Day);

            if (aniversario < DateTime.Now)
            {
                aniversario = aniversario.AddYears(1);
            }

            return aniversario;

        }
    }

}

