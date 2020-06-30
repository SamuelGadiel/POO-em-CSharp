using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal___Database
{
    class EmpregadoHorista : Empregado
    {
        private int nHoras;
        private double precoH;

        public EmpregadoHorista()
        {
            nHoras = 0;
            precoH = 0.0;
        }

        public EmpregadoHorista(String nome, String cpf, String endereco, int _nHoras, double _precoH) : 
            base(nome, cpf, endereco)
        {
            nHoras = _nHoras;
            precoH = _precoH;
        }

        public int NHoras { get => nHoras; set => nHoras = value; }
        public double PrecoH { get => precoH; set => precoH = value; }

        public override double salarioLiq()
        {
            double bruto = nHoras * precoH;

            if (bruto < 5000)
            {
                return (bruto * 0.85);
            }
            else
            {
                return (bruto * 0.725);
            }
        }
    }
}
