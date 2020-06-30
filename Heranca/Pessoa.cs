using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    class Pessoa
    {
        // Atributos
        protected String nome;
        protected int idade;

        // Construtores
        public Pessoa(String _nome = "", int _idade = 0)
        {
            nome = _nome;
            idade = _idade;
        }

        public String Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }


    }

}
