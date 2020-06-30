using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio05
{
    class Empregado
    {
        protected String nome;
        protected String cpf;
        protected String endereco;

        public Empregado()
        {
            nome = "";
            cpf = "";
            endereco = "";

        }

        public Empregado(String _nome, String _cpf, String _endereco)
        {
            nome = _nome;
            cpf = _cpf;
            endereco = _endereco;
        }

        public String Nome { get => nome; set => nome = value; }
        public String CPF { get => cpf; set => cpf = value; }
        public String Enredeco { get => endereco; set => endereco = value; }

        public virtual double salarioLiq()
        {
            return 1.0;
        }
    }
}
