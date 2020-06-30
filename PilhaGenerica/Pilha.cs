using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaGenerica
{
    class Pilha<TAD>: Object
    {
        private NohPilha<TAD> topo;

        public Pilha()
        {
            topo = null;
        }

        public bool isEmpty()
        {
            return (topo == null ? true : false);
        }

        public void push(TAD insertItem)
        {
            if (isEmpty())
                topo = new NohPilha<TAD>(insertItem);
            else
            {
                NohPilha<TAD> novoNoh = new NohPilha<TAD>(insertItem, topo);
                topo = novoNoh;
            }
        }

        public TAD pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia");
                throw new Exception();
            }
            else
            {
                TAD temp = topo.Data;
                topo = topo.NextNoh;
                return (temp);
            }
        }


        /*
        public void pop()
        {
            if (isEmpty() == false)
            {
                topo = topo.NextNoh;

            }
        }
        */

        public void print()
        {
            if (isEmpty())
                Console.WriteLine("Pilha Vazia");
            else
            {
                Console.WriteLine("Status atual da Pilha:");
                NohPilha<TAD> temp = topo;

                while (temp != null)
                {
                    Console.WriteLine("\n" + temp.Data);
                    temp = temp.NextNoh;
                }
            }
        }

    }
}
