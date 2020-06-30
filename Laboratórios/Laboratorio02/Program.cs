using System;
using System.Collections.Generic;

namespace Laboratorio02
{
    class MainClass
    {
        private static Estacionamento achaCarro(String placa_carro, Estacionamento[] estacionamento)
        {
            Estacionamento carro = null;
            for (int i = 0; i < estacionamento.Length; i++)
            {
                if (placa_carro == estacionamento[i].Placa)
                {
                    carro = estacionamento[i];
                    break;
                }
            }
            return carro;
        }

        public static void Main(string[] args)
        {
            const int TAMANHO = 5;
            Estacionamento[] listaCarros;
            listaCarros = new Estacionamento[TAMANHO];
            int counter = 0;
            int exit = 0;

            while (exit == 0)
            {
                Console.Clear();

                Console.WriteLine("------------Escolha uma opção-------------");
                Console.WriteLine("|  [1] - Cadastrar um carro              |");
                Console.WriteLine("|  [2] - Imprimir relatório de um carro  |");
                Console.WriteLine("|  [3] - Sair                            |");
                Console.WriteLine("------------------------------------------");
                String escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.Clear();

                        if (counter < TAMANHO)
                        {
                            listaCarros[counter] = new Estacionamento();
                            listaCarros[counter].AskData();
                            counter++;
                        }

                        break;

                    case "2":
                        Console.Clear();

                        Estacionamento temp;
                        for (int i = 0; i < counter; i++)
                        {
                            temp = listaCarros[i];
                            Console.WriteLine("Carro: " + temp.Placa);
                        }

                        String placa_carro = Console.ReadLine();

                        temp = achaCarro(placa_carro, listaCarros);
                        temp.PrintCarData();
                        temp.Price();

                        Console.ReadLine();

                        break;

                    case "3":
                        exit = 1;

                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Escolha uma das opções mostradas no menu\n");

                        break;
                }
            }
        }
    }
}