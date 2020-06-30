using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregado_Gerente
{
    class Gerente : Empregado
    {
        private String secretaria;

        public Gerente()
        {
            secretaria = "";
        }

        public Gerente(String _nome, String _secao, double _salario, String _secretaria) : base(_nome, _secao, _salario)
        {
            secretaria = _secretaria;
        }

        public String Secretaria { get => secretaria; set => secretaria = value; }


        public override void aumentaSalario(double percentual)
        {
            double n_percentagem = percentual + 15;
            base.aumentaSalario(n_percentagem);
        }

    }
}
