
using Q_6;

namespace AT_CSharp
{
    public class Program
    {
        public static void Main()
        {
            Aluno aluno = new Aluno("Gabriel", 1234, "Eng. Software", [10, 8, 9]);

            aluno.ExibirDados();
            aluno.VerificarAprovacao();

        }

    }
}

