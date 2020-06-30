using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio08
{
    class Pilha
    {
        private NohPilha topo;

        public Pilha()
        {
            topo = null;
        }

        private bool isEmpty()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void Push(char insertItem)
        {
            if (isEmpty())
                topo = new NohPilha(insertItem);
            else
            {
                NohPilha next = new NohPilha(insertItem, topo);
                topo = next;

            }
        }

        public void print()
        {
            if (isEmpty())
                Console.WriteLine("Pilha vazia");
            else
            {
                NohPilha aux = topo;
                Console.WriteLine("Status atual da pilha");

                while (aux.NextNoh != null)
                {
                    Console.WriteLine("\n" + aux.Data);
                    aux = aux.NextNoh;
                }

            }
        }
    }
}
