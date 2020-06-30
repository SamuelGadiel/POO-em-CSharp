using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPilhaGenerica
{
    class NohPilha <TAD> : Object // TAD = tipo abstrato de dado
    {
        private TAD data;
        private NohPilha<TAD> nextNoh;

        public NohPilha()
        {
            nextNoh = null;
        }

        public NohPilha(TAD texto)
        {
            data = texto;
            nextNoh = null;
        }

        public NohPilha(TAD texto, NohPilha<TAD> noh)
        {
            data = texto;
            nextNoh = noh;
        }

        public TAD Data { get => data; set => data = value; }
        public NohPilha<TAD> NextNoh { get => nextNoh; set => nextNoh = value; }
    }
}
