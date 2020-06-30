﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTratamentoExcecao
{
    class Program
    {
        public static int quociente(int numerador, int denominador)
        {
            return (numerador / denominador);
        }

        static void Main(string[] args)
        {
            bool continueLoop = true;

            do
            {
                try
                {
                    int numerador, denominador;

                    Console.WriteLine("Entre o numerador: ");
                    numerador = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Entre o denominador: ");
                    denominador = Convert.ToInt32(Console.ReadLine());

                    double resultado = quociente(numerador, denominador);

                    Console.WriteLine("Resultado = " + resultado);
                    Console.ReadLine();

                    continueLoop = false;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Precisa ser um numero inteiro. Tente de novo");
                    Console.ReadLine();
                }

                catch (DivideByZeroException dividebyzeroexception)
                {
                    Console.WriteLine("exception: " + dividebyzeroexception);
                    Console.WriteLine("não existe divisão por zero. tente de novo. \n");
                    Console.ReadLine();
                }
                

            } while (continueLoop);
            
        }
    }
}
