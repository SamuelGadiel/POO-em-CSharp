using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaDuplamenteEncadeada
{
    class NohLista
    {
        private NohLista previo;
        int data;
        private NohLista next;

        public NohLista()
        {
            previo = null;
            data = 0;
            next = null;
        }

        public NohLista(int n)
        {
            previo = null;
            data = n;
            next = null;
        }

        public NohLista Previo { get => previo; set => previo = value; }
        public int Data { get => data; set => data = value; }
        public NohLista Next { get => next; set => next = value; }

    }
}
