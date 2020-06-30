using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            Aluno a2 = new Aluno("gustavo", 20, "Comp");

            a1.imprimeDados();
            Console.WriteLine("\n");
            a2.imprimeDados();

            Console.ReadLine();
        }
    }
}
