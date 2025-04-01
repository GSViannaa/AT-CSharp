
using Q_7;

namespace AT_CSharp
{
    public class Program
    {
        static void Main()
        {
            ContaBancaria conta = new ContaBancaria("Gabriel", 5000);

            conta.Sacar(10000);
            conta.Depositar(15000);
            conta.Sacar(4000);

            conta.ExibirInformoacao();

        }
    }
}