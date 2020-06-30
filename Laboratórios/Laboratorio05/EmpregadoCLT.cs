using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio05
{
    class EmpregadoCLT : Empregado
    {
        private double sBrutoCLT;

        public EmpregadoCLT()
        {
            sBrutoCLT = 0.0;
        }

        public EmpregadoCLT(string nome, string cpf, string endereco, double _sBrutoCLT) :
            base(nome, cpf, endereco)
        {
            sBrutoCLT = _sBrutoCLT;
        }

        public double SBrutoCLT { get => sBrutoCLT; set => sBrutoCLT = value; }

        public override double salarioLiq()
        {
            return (sBrutoCLT * 0.85);
        }

    }
}
