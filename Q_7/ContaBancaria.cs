using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_7
{
    class ContaBancaria
    {
        public string titular;
        private double saldo;
        public ContaBancaria(string titular, double saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        public double getSaldo
        {
            get { return saldo; }
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("\nO valor do depósito deve ser positivo");
            }
            else
            {
                saldo += valor;
                Console.WriteLine($"\nDepósito de R${valor} realizado com sucesso");
            }

        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("\nValor inválido");
            }
            else if (valor > saldo)
            {
                Console.WriteLine("\nSaldo insuficiente para realizar o saque");
            }
            else
            {
                Console.WriteLine($"\nSaque de R${valor} realizado com sucesso");
                saldo -= valor;
            }
        }

        public void ExibirInformoacao()
        {
            Console.WriteLine("==== Informações da conta ====");
            Console.WriteLine($"\nTitular: {titular}");
            Console.WriteLine($"Saldo Atual: R${saldo}");
        }

    }
}
