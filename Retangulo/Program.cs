using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caRetangulo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Retangulo r1 = new Retangulo();

            r1.setBasis(25.0);

            Console.WriteLine("-----R1-----");
            Console.WriteLine(r1.getBasis());
            Console.WriteLine(r1.getAltura());
            Console.WriteLine();

            Retangulo r2 = new Retangulo(15.0, 25.0);

            Console.WriteLine("-----R2-----");
            Console.WriteLine(r2.getBasis());
            Console.WriteLine(r2.getAltura());

            Console.WriteLine("\n-----Area-----");
            Console.WriteLine(r1.Area());
            Console.WriteLine(r2.Area());

            Console.WriteLine("\n-----Perimetro-----");
            Console.WriteLine(r1.Perimetro());
            Console.WriteLine(r2.Perimetro());
        }
    }
}
