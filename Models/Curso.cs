using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentoNet.Models
{
    public class Curso(string nome)
    {
        public string Nome { set; get; } = nome;

        public List<Pessoa> Alunos { set; get; } = new List<Pessoa>();

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);

        }

        public void AdicionarAluno()
        {
            Alunos.Add(new Pessoa());
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso {Nome}");
            /* Orderna lista dos Alunos */
            Alunos.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            return Alunos.Count;
        }

    }
}