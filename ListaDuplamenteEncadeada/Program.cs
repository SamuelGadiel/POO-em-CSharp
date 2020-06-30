using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaDuplamenteEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            bool saida = false;

            while (!saida)
            {
                Console.Clear();

                Console.WriteLine("---------------------- Lista ----------------------");
                Console.WriteLine("| 1 - Inserir um inteiro na lista no FIM          |");
                Console.WriteLine("| 2 - Inserir um inteiro na lista no INICIO       |");
                Console.WriteLine("| 3 - Remover um elemento da lista                |");
                Console.WriteLine("| 4 - Inserir um elemento ANTES de outro na lista |");
                Console.WriteLine("| 5 - Inserir um elemento APÓS outro na lista     |");
                Console.WriteLine("| 6 - Imprimir a lista INICIO -> FIM              |");
                Console.WriteLine("| 7 - Imprimir a lista FIM -> INICIO              |");
                Console.WriteLine("| 8 - Sair                                        |");
                Console.WriteLine("---------------------------------------------------");

                int escolha = Convert.ToInt32(Console.ReadLine());
                int valor;

                switch (escolha)
                {
                    case 1:
                        Console.Write("Insira dado: ");
                        valor = Convert.ToInt32(Console.ReadLine());

                        lista.insereFim(valor);
                        break;

                    case 2:
                        Console.Write("Insira dado: ");
                        valor = Convert.ToInt32(Console.ReadLine());

                        lista.insereInicio(valor);
                        break;

                    case 3:
                        Console.Write("Insira valor a ser removido: ");
                        valor = Convert.ToInt32(Console.ReadLine());

                        lista.remove(valor);
                        break;
                   
                    case 4:
                        Console.Write("Insira dado: ");
                        valor = Convert.ToInt32(Console.ReadLine());

                        lista.insereAntes(valor);
                        break;

                    case 5:
                        Console.Write("Insira dado: ");
                        valor = Convert.ToInt32(Console.ReadLine());

                        lista.insereApos(valor);
                        break;

                    case 6:
                        lista.imprimeED();
                        Console.ReadLine();
                        break;

                    case 7:
                        lista.imprimeDE();
                        Console.ReadLine();
                        break;
                    
                    case 8:
                        saida = true;
                        break;

                    default:
                        Console.WriteLine("Escolha alguma opção");
                        break;
                }
            }
        }
    }
}
