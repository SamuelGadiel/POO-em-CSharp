using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFila
{
    class NohFila
    {
        private int? data;
        private NohFila proximo;

        public NohFila()
        {
            data = null;
            proximo = null;
        }

        public NohFila(int _data)
        {
            data = _data;
            proximo = null;
        }

        public NohFila(int _data, NohFila _anterior)
        {
            data = _data;
            proximo = _anterior;
        }
        
        public int? Data { get => data; set => data = value; }
        public NohFila Proximo { get => proximo; set => proximo = value; }
    }
}
