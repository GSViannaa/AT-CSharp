

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o primero número:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha a operação: 1 - Soma |  2 - Subtração |  3 - Multiplicação |  4 - Divisão");
        int operacao = int.Parse(Console.ReadLine());


        if (operacao == 4 && (numero1 == 0 || numero2 == 0))
        {
            Console.WriteLine("Impossível dividir por zero");
            return;
        }

        switch (operacao)
        {
            case 1:

                Console.WriteLine("Resultado: " + (numero1 + numero2));
                break;

            case 2:

                Console.WriteLine("Resultado: " + (numero1 - numero2));
                break;

            case 3:

                Console.WriteLine("Resultado: " + (numero1 * numero2));
                break;

            case 4:

                Console.WriteLine("Resultado: " + (numero1 / numero2));
                break;

            default:

                Console.WriteLine("Operação inválida");
                break;
        }



    }
}
