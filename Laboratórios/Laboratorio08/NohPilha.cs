using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio08
{
    class NohPilha
    {
        private char? data;
        private NohPilha nextNoh;

        public NohPilha()
        {
            data = null;
            nextNoh = null;
        }

        public NohPilha(char valor)
        {
            data = valor;
            nextNoh = null;
        }

        public NohPilha(char valor, NohPilha noh)
        {
            data = valor;
            nextNoh = noh;
        }

        public char? Data { get => data; set => data = value; }
        public NohPilha NextNoh { get => nextNoh; set => nextNoh = value; }
    }
}
