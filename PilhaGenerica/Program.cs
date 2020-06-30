using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Pilha<int> pint = new Pilha<int>();
            Pilha<string> pstr = new Pilha<string>();

            pint.push(1);
            pint.push(2);
            pint.push(3);

            pstr.push("demais");
            pstr.push("é");
            pstr.push("Pilha");

            pint.print();
            pstr.print();

            Console.ReadLine();
            */

            Pilha<string> pilha = new Pilha<string>();
            bool saida = false;
            while (!saida)
            {
                Console.Clear();

                Console.WriteLine("-------------- Pilha --------------");
                Console.WriteLine("| 1 - Inserir uma string na pilha |");
                Console.WriteLine("| 2 - Remover uma string da pilha |");
                Console.WriteLine("| 3 - Mostrar a pilha             |");
                Console.WriteLine("| 4 - Sair                        |");
                Console.WriteLine("-----------------------------------");

                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Write("Insira dado: ");

                        string texto = Console.ReadLine();
                        pilha.push(texto);
                        break;
                    case 2:
                        pilha.pop();
                        break;
                    case 3:
                        pilha.print();
                        Console.ReadLine();
                        break;
                    case 4:
                        saida = true;
                        break;
                }
            }


        }
    }
}
