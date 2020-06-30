using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    class Aluno : Pessoa
    {
        // Atributos
        private String curso;

        // Construtores
        public Aluno(String _nome = "", int _idade = 0, String _curso="") : base(_nome, _idade)
        {
            curso = _curso;
        }

        // Metodos
        public void imprimeDados()
        {
            Console.WriteLine("Dados do aluno:");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Curso: " + curso);
        }
    }
}
