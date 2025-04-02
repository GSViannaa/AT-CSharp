
public class Program
{
    public static void Main()
    {
        Random rand = new Random();
        int numero = rand.Next(50) + 1;
       
        int contador = 0;
        int chute;

    
        do
        {
            Console.WriteLine("Tente adivinhar um número de 1 a 50");
            chute = int.Parse(Console.ReadLine());
            
            if(chute < 1 || chute > 50)
            {
                Console.WriteLine("ERRO: Número inválido");
                break;
            }
            else
            {
                contador++;
            }
            
        } 
        while (contador < 5 || chute == numero);
    }
}
