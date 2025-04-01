using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_8
{
    class Funcionario
    {
        protected string nome;
        protected string cargo;
        protected double salarioBase;

        public Funcionario(string nome, string cargo, double salarioBase)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salarioBase = salarioBase;
        }

        public virtual double CalcularSalario()
        {
            return salarioBase;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome} | Cargo: {cargo} | Salário: R$ {CalcularSalario():F2}");
        }
    }
}
