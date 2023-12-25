using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace FundamentoNet.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            Console.WriteLine($"Informe o nome do aluno: ");
            Nome = Console.ReadLine();
            Console.WriteLine($"Informe o sobrenome do aluno: ");
            Sobrenome = Console.ReadLine();
        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

        }
        private string _nome;

        private string _sobrenome;

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public string Sobrenome
        {
            get => _sobrenome;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Sobrenome não pode ser vazio");
                }
                _sobrenome = value.ToUpper();
            }
        }
        public string Nome
        {
            get => _nome;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }
                else
                {
                    if (value.Length < 3)
                    {
                        throw new ArgumentException("Nome deve ter pelo menos 3 caracteres");
                    }
                    else
                    {
                        _nome = value.ToUpper();
                    }
                }
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto}");

        }
    }
}
