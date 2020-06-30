using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados
{
    class Empregado
    {
        protected String primeiroNome, segundoNome, cpf;


        public Empregado()
        {
            primeiroNome = "";
            segundoNome = "";
            cpf = "";
        }

        public Empregado(String _primeiroNome, String _segundoNome, String _cpf)
        {
            primeiroNome = _primeiroNome;
            segundoNome = _segundoNome;
            cpf = _cpf;
        }


        public String PrimeiroNome { get => primeiroNome; set => primeiroNome = value; }
        public String SegundoNome { get => segundoNome; set => segundoNome = value; }
        public String CPF { get => cpf; set => cpf = value; }

        public virtual double getSalLiquido( )
        {
            return 1.0;
        }

    }
}
