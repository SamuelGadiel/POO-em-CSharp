using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    class Vetor3D : Vetor2D
    {
        // Atributos
        private double z;

        // Construtores
        public Vetor3D()
        {
            z = 0.0;
        }


        public Vetor3D(double _x, double _y, double _z) : base(_x, _y)
        {
            z = _z;
        }

        // Getter e Setter
        public double Z { get => z; set => z = value; }

        // Metodos
        public Vetor3D produtoVetorial(Vetor3D vet)
        {
            double auxX, auxY, auxZ;

            auxX = (y * vet.Z) - (z * vet.Y);
            auxY = (z * vet.X) - (x * vet.Z);
            auxZ = (x * vet.Y) - (y * vet.X);

            Vetor3D resultado = new Vetor3D(auxX, auxY, auxZ);

            return resultado;
        }
        
        public double modulo()
        {
            return ( Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)) );
        }
        
    }
}
