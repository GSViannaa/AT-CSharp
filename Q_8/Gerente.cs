using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_8
{
    class Gerente : Funcionario
    {
        public Gerente(string nome, string cargo, double salarioBase)
             : base(nome, cargo, salarioBase) { }


        public override double CalcularSalario()
        {
            return salarioBase * 1.2;
        }
    }
}
