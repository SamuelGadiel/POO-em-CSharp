using System;
namespace Laboratorio01
{
    public class Vetor2D
    {
        // Atributos
        private double x;
        private double y;

        // Construtores
        public Vetor2D()
        {
            x = 0;
            y = 0;
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
        // Produto Escalar de dois vetores
        public double produtoEscalar(Vetor2D _vetor)
        {
            return ((x * _vetor.X) + (y * _vetor.Y));
        }

        // Modulo de um vetor
        public double modulo()
        {
            return (Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2))));
        }

        // Angulo entre dois vetores
        public double anguloVetores(Vetor2D _vetor)
        {
            double numerador = produtoEscalar(_vetor);
            double denomimador = modulo() * _vetor.modulo();

            double valor = numerador/denomimador;

            return (Math.Acos(valor));
        }

        // Projeção de um vetor em outro
        public double[] projecaoVetores(Vetor2D _vetor)
        {
            double numerador = produtoEscalar(_vetor);
            double denominador = Math.Pow(modulo(), 2);

            double aux = numerador / denominador;

            double[] valor = { aux * _vetor.X, aux * _vetor.Y };
            return valor;
        }
    }
}
