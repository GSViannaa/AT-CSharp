using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_9
{
    class Produtos
    {
        private string nome;
        private int quantidade;
        private double preco;

        public Produtos(string nome, int quantidade, double preco)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome} | Quantidade: {quantidade} | Preço: {preco}");
        }

    }
}
