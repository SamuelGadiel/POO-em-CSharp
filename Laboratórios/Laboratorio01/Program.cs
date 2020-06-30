using System;

namespace Laboratorio01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Vetor2D vetor1 = new Vetor2D(1, 3);
            Vetor2D vetor2 = new Vetor2D(2, 4);

            Console.WriteLine("Vetor 1: " + String.Join(", ", (vetor1.X, vetor1.Y)));
            Console.WriteLine("Vetor 2: " + String.Join(", ", (vetor2.X, vetor2.Y)));

            Console.WriteLine("\nProduto escalar entre V1 e V2");
            Console.WriteLine(vetor1.produtoEscalar(vetor2));

            Console.WriteLine("\nMódulo de V1 e Módulo de V2");
            Console.WriteLine(vetor1.modulo());
            Console.WriteLine(vetor2.modulo());

            Console.WriteLine("\nAngulo entre V1 e V2");
            Console.WriteLine(vetor1.anguloVetores(vetor2));

            Console.WriteLine("\nProjeção entre V1 e V2");
            double[] proj = vetor1.projecaoVetores(vetor2);
            Console.WriteLine("(" + proj[0] + ", " + proj[1] + ")");
        }
    }
}
