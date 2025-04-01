

using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Escreva seu nome:");
        string nome = Console.ReadLine().ToLower();

        if (string.IsNullOrEmpty(nome) || TemCaracterEspicial(nome) || Regex.IsMatch(nome, @"\d"))
        {
            Console.WriteLine("Nome inválido");
            return;
        }

        static bool TemCaracterEspicial(string nome)
        {
            nome = nome.Replace(" ", "");
            return Regex.IsMatch(nome, @"[^a-zA-Z0-9]");
        }

        char[] nomeCifrado = new char[nome.Length];

        char[] alfabeto =
            {
                 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
             };

        for (int i = 0; i < nome.Length; i++)
        {
            if (nome[i] == ' ')
            {
                nomeCifrado[i] = ' ';
                continue;
            }

            for (int j = 0; j < alfabeto.Length; j++)
            {
                if (nome[i] == alfabeto[j])
                {
                    nomeCifrado[i] = alfabeto[(j + 2) % 26];

                    if (i == 0 || nomeCifrado[i - 1] == ' ')
                    {
                        nomeCifrado[i] = char.ToUpper(nomeCifrado[i]);
                    }

                }
            }
        }

        Console.WriteLine("Nome cifrado: " + new string(nomeCifrado));

    }
}