using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor3D vetor1 = new Vetor3D();
            Vetor3D vetor2 = new Vetor3D();
            Vetor3D prodVetorial;
            double resultado_modulo;

            Console.WriteLine("----- Valores iniciais dos vetores -----");
            Console.WriteLine("[ Vetor 1 ]");
            Console.WriteLine("x = " + vetor1.X + "\ny = " + vetor1.Y + "\nz = " + vetor1.Z);
            Console.WriteLine("\n[ Vetor 2 ]");
            Console.WriteLine("x = " + vetor2.X + "\ny = " + vetor2.Y + "\nz = " + vetor2.Z);

            Console.WriteLine("\n\n----- Colocando valores para os Vetores -----");
            
            vetor1.X = 1.0;
            vetor1.Y = 2.0;
            vetor1.Z = 1.0;

            vetor2.X = 2.0;
            vetor2.Y = 2.0;
            vetor2.Z = 3.0;

            Console.WriteLine("[ Vetor 1 ]");
            Console.WriteLine("x = " + vetor1.X + "\ny = " + vetor1.Y + "\nz = " + vetor1.Z);
            Console.WriteLine("\n[ Vetor 2 ]");
            Console.WriteLine("x = " + vetor2.X + "\ny = " + vetor2.Y + "\nz = " + vetor2.Z);

            Console.WriteLine("\n\n----- Produto vetorial vetor1 x vetor2 -----");

            prodVetorial = vetor1.produtoVetorial(vetor2);

            Console.WriteLine("[ vetor1 x vetor2 ]");
            Console.WriteLine("x = " + prodVetorial.X + "\ny = " + prodVetorial.Y + "\nz = " + prodVetorial.Z);

            Console.WriteLine("\n----- Modulo dos Vetores -----");

            resultado_modulo = vetor1.modulo();
            Console.WriteLine("||vetor1|| = " + resultado_modulo);

            resultado_modulo = vetor2.modulo();
            Console.WriteLine("||vetor2|| = " + resultado_modulo);


            Console.ReadLine();
            
        }
    }
}
