using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_11
{
    internal class Contatos
    {
        private string nome;
        private string numero;
        private string email;

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
}
