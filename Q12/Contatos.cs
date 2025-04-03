using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_11
{
    internal class Contatos
    {
        public string nome;
        public string numero;
        public string email;

        public Contatos(string nome, string numero, string email)
        {
            this.nome = nome;
            this.numero = numero;
            this.email = email;
        }


        public void SalvarContato()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("contatos.txt", true))
                {
                    sw.WriteLine($"{nome},{numero},{email}");

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar no arquivo: {ex.Message}");
            }
        }


    }
    abstract class ContatoFormatter
    {
        public abstract void ExibirContatos(List<Contatos> contatos);
    }

    class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contatos> contatos)
        {
            Console.WriteLine("## Lista de Contatos");

            foreach (var contato in contatos)
            {
                Console.WriteLine($"- **Nome:** {contato.nome}\n");
                Console.WriteLine($"- 📞 Telefone: {contato.numero}\n");
                Console.WriteLine($"- 📧 Email: {contato.email}\n");

            }
        }
    }

    class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contatos> contatos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("| Nome | Telefone | Email |");
            Console.WriteLine("----------------------------------------");

            foreach (var contato in contatos)
            {
                Console.WriteLine($"| {contato.nome} | {contato.numero} | {contato.email} |");
                Console.WriteLine("----------------------------------------");
            }
            
        }
    }

    class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contatos> contatos)
        {
            foreach (var contato in contatos)
            {
                Console.WriteLine($"Nome: {contato.nome} | Telefone: {contato.numero} | Email: {contato.email}");
            }
        }
    }

}
