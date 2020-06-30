using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFila
{
    class Fila
    {
        private NohFila start;
        private NohFila end;

        public Fila()
        {
            start = null;
            end = null;
        }

        public bool isEmpty()
        {
            return (start == null ? true : false); 
        }

        public void insere(int valor)
        {
            NohFila novo = new NohFila(valor);
            if (isEmpty() == true)
            {
                start = novo;
                end = novo;
            }
            else
            {
                end.Proximo = novo;
                end = novo;
            }
        }

        public void imprime()
        {
            if(isEmpty() == true)
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {
                NohFila temp = start;
                while (temp != null)
                {
                    Console.Write(temp.Data + " ");
                    temp = temp.Proximo;
                }
            }

        }

        public int? retirar()
        {
            if(isEmpty() == true)
            {
                Console.WriteLine("Fila Vazia");
                return null;
            }
            else
            {
                int? temp = start.Data;
                start = start.Proximo;
                return temp;
            }
        }

        // remover também

    }
}
