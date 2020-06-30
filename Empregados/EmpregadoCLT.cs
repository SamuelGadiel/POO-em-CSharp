using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregados
{
    class EmpregadoCLT : Empregado
    {
        private double salario_mensal;

        public EmpregadoCLT()
        {
            salario_mensal = 0.0;
        }

        public EmpregadoCLT( String _primeiroNome, String _segundoNome, String _cpf, double _salario_mensal) : 
            base(_primeiroNome, _segundoNome, _cpf)
        {
            salario_mensal = _salario_mensal;
        }

        // Getter e Setter
        public double SalarioMensal { get => salario_mensal; set => salario_mensal = value; }

        public override double getSalLiquido()
        {
            if (salario_mensal >= 4000.00)
            {
                return (salario_mensal * 0.725);
            }
            else
            {
                return (salario_mensal * 0.850);
            }
        }
    }

}
