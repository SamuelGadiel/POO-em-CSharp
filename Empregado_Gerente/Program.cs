using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregado_Gerente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste de Herança");

            Empregado e1 = new Empregado("João", "Contabilidade", 1000.0);
            Gerente g1 = new Gerente("José","Almoxarifado", 1000.0 ,"Maria");

            Console.WriteLine(g1.Secretaria);
            Console.WriteLine("Nome do Gerente: " + g1.Nome);
            Console.WriteLine("\nSalario ANTES do Empregado: " + e1.Salario);
            Console.WriteLine("Salario ANTES do Gerente: " + g1.Salario);
            e1.aumentaSalario(30.0);
            g1.aumentaSalario(30.0);
            Console.WriteLine("\nSalario DEPOIS do Empregado: " + e1.Salario);
            Console.WriteLine("Salario DEPOIS do Gerente: " + g1.Salario);

            Console.ReadLine();

        }
    }
}
