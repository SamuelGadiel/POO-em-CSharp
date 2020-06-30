using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados
{
    class EmpregadoHorista : Empregado
    {
        private double nro_horas;
        private double qtd_horas;

        public EmpregadoHorista()
        {
            nro_horas = 0.0;
            qtd_horas = 0.0;
        }

        public EmpregadoHorista(String _primeiroNome, String _segundoNome, String _cpf, double _nro_horas, 
            double _qtd_horas) : base(_primeiroNome, _segundoNome, _cpf)
        {
            nro_horas = _nro_horas;
            qtd_horas = _qtd_horas;
        }

        public double NHoras { get => nro_horas; set => nro_horas = value; }
        public double QHoras { get => qtd_horas; set => qtd_horas = value; }

        public override double getSalLiquido()
        {
            return ((nro_horas * qtd_horas) * 0.85);
        }

    }
}
