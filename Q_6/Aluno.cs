using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_6
{
    public class Aluno
    {

        private string nome;
        private short matricula;
        private string curso;
        private double[] notas;
        private double media;

        public Aluno(string nome, short matricula, string curso, double[] notas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.curso = curso;
            this.notas = notas;
        }

        private double CalcularMedia()
        {

            foreach (double nota in notas)
            {
                media += nota;
            }

            return media / notas.Length;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Matrícula: " + matricula);
            Console.WriteLine("Curso: " + curso);
            Console.WriteLine($"Média:{CalcularMedia():F2}");

        }

        public void VerificarAprovacao()
        {
            if (CalcularMedia() >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
