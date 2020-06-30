using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaDinamica
{
    class NohPilha
    {
        private int data;
        private NohPilha nextNoh;

        public NohPilha()
        {
            data = 0;
            nextNoh = null;
        }

        public NohPilha(int valor)
        {
            data = valor;
            nextNoh = null;
        }

        public NohPilha(int valor, NohPilha noh)
        {
            data = valor;
            nextNoh = noh;
        }

        public int Data { get => data; set => data = value; }
        public NohPilha NextNoh { get => nextNoh; set => nextNoh = value; }

    }
}
