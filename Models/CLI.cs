using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentoNet.Models
{
    public class CLI
    {
        public CLI()
        {
            Cursos = [];
            StartMenu();
        }

        public List<Curso> Cursos { get; set; }

        public void StartMenu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao sistema de cadastro de cursos!");
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine();
            Console.WriteLine("1 - Novo Curso");
            Console.WriteLine("2 - Cadastrar Aluno no curso");
            Console.WriteLine("3 - Listar Alunos do Curso");
            Console.WriteLine("4 - Listar Cursos");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.WriteLine("Digite uma opção: ");
            string _opt = Console.ReadLine();
            int opt = 5;
            if (_opt != "")
            {
                opt = Convert.ToInt32(_opt);
            }

            switch (opt)
            {
                case 1:
                    Console.WriteLine("Digite o nome do curso: ");
                    Curso curso = new(Console.ReadLine());
                    Cursos.Add(curso);
                    Console.WriteLine("Curso cadastrado com sucesso!");
                    StartMenu();
                    break;
                case 2:
                    int contador = 0;
                    if (Cursos.Count == 0)
                    {
                        Console.WriteLine("Nenhum curso cadastrado!");
                        StartMenu();
                    }

                    Console.WriteLine("Selecione o curso:");
                    foreach (Curso c in Cursos)
                    {
                        Console.WriteLine($"{++contador} - {c.Nome}");
                    }
                    Cursos[Convert.ToInt32(Console.ReadLine()) - 1].AdicionarAluno();
                    Console.WriteLine("Aluno cadastrado com sucesso!");
                    StartMenu();

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    Console.WriteLine("Saindo do sistema...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    StartMenu();
                    break;


            }
        }
    }
}