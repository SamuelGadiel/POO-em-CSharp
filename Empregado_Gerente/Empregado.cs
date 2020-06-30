using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregado_Gerente
{
    class Empregado
    {
        protected String nome;
        protected String secao;
        protected double salario;

        public Empregado()
        {
            nome = "";
            secao = "";
            salario = 0.0;
        }

        public Empregado(String _nome, String _secao, double _salario)
        {
            nome = _nome;
            secao = _secao;
            salario = _salario;
        }

        public String Nome { get => nome; set => nome = value; }
        public String Secao { get => secao; set => secao = value; }
        public double Salario { get => salario; set => salario = value; }

        public virtual void aumentaSalario(double percentual)
        {
            salario = salario * (1 + percentual / 100);
        }
    }
}
