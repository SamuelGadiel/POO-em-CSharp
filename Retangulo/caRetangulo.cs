using System;

namespace caRetangulo
{
    class Retangulo
    {
        // atributos
        private double basis;
        private double altura;

        // metodos
        public Retangulo() // construtor default
        {
            basis = 10.0;
            altura = 20.0;
        }

        public Retangulo(double b, double a)
        {
            basis = b;
            altura = a;
        }

        public double getBasis()
        {
            return basis;
        }

        public void setBasis(double _basis)
        {
            basis = _basis;
        }

        public double getAltura()
        {
            return altura;
        }

        public void setAltura(double _altura)
        {
            altura = _altura;
        }

        public double Area()
        {
            return (basis * altura);
        }

        public double Perimetro()
        {
            return ((2 * basis) + (2 * altura));
        }

    }
}
