using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght;
            string expressao;
            Pilha pilha = new Pilha();

            Console.WriteLine("Escreva a expressão matemática");
            expressao = Console.ReadLine();

            lenght = expressao.Length;
            Console.WriteLine(lenght);

            for(int i = 0; i< lenght; i++)
            {
                char sim = expressao[i];
                if (sim == '{' || sim == '[' || sim == '(')
                {
                    pilha.Push(sim);
                }
                
                
            }

            pilha.print();
            Console.ReadLine();

        }
    }
}
