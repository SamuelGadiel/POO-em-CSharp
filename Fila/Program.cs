using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace caFila
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila f = new Fila();
            float aux = 1;
            while (aux != 0)
            {
                Console.WriteLine("Escolha uma opção do menu :\n");
                Console.WriteLine(" [1] - Inserir elemento na fila");
                Console.WriteLine(" [2] - Remover elemento da fila");
                Console.WriteLine(" [3] - Imprimir todos elementos da fila");
                Console.WriteLine(" [4] - Sair");

                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("Digite o elemento a ser inserido:\n");
                        int valor = Convert.ToInt32(Console.ReadLine());
                        f.insere(valor);
                        Console.Clear();
                        break;

                    case "2":
                        Console.Write("Um elemento  foi removido");
                        f.retirar();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Write("A fila encontra-se na seguinte disposição :\n");
                        f.imprime();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "4":
                        aux = 0;
                        Console.Clear();
                        break;
                    default:
                        Console.Write("Favor selecionar uma das opções mostradas no menu\n");
                        break;
                }


            }

        } // fim da classe void Main
    }
}
