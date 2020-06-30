using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    class Vetor2D
    {
        // Atributos
        protected double x;
        protected double y;

        // Construtores
        public Vetor2D()
        {
            x = 0.0;
            y = 0.0;
        }

        public Vetor2D(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        // Getters e Setters
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        // Metodos
        
    }
}
