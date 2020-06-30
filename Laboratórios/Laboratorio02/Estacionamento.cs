using System;
namespace Laboratorio02
{
    public class Estacionamento
    {
        // atributos
        String placa;
        String marca;
        Tempo entrada;
        Tempo saida;

        // Construtores
        public Estacionamento()
        {
            placa = "";
            marca = "";
            entrada = new Tempo();
            saida = new Tempo();
        }

        public Estacionamento(String _placa, String _marca, Tempo _entrada, Tempo _saida)
        {
            placa = _placa;
            marca = _marca;
            entrada = _entrada;
            saida = _saida;
        }

        // Getters e Setters
        public String Placa { get => placa; set => placa = value; }

        // Métodos
        public void AskData()
        {
            Console.Write("Placa do carro: ");
            String _placa = Console.ReadLine();

            Console.Write("Marca do carro: ");
            String _marca = Console.ReadLine();

            Console.WriteLine("\nFormato do horário deve ser \"hh:mm:ss\"");

            Console.Write("Horario de Entrada: ");
            Tempo _entrada = new Tempo();
            _entrada.AskForTime();

            Console.Write("Horario de Saida: ");
            Tempo _saida = new Tempo();
            _saida.AskForTime();

            placa = _placa;
            marca = _marca;
            entrada = _entrada;
            saida = _saida;
        }

        public void PrintCarData()
        {
            Console.Clear();
            Console.WriteLine("Placa do carro: " + placa);
            Console.WriteLine("Marca do carro: " + marca);
            Console.Write("Entrada: "); entrada.PrintTime();
            Console.Write("Saida: "); saida.PrintTime();
        }

        public void Price()
        {
            decimal valor_base = 7.00M;
            decimal valor_total;
            Tempo duracao = new Tempo();

            duracao = saida.SubTimes(entrada);

            // A pessoa pagará pela hora completa mesmo que não tenha ficado todos os 60 minutos
            // Exemplo: Duração de 02:25:00 -> A pessoa pagará por 3 horas
            // Exemplo: Duração de 02:00:01 -> A pessoa pagará por 3 horas

            if(duracao.Min > 0 || duracao.Seg > 0)
            {
                duracao.Hora++;
            }

            valor_total = duracao.Hora * valor_base + (duracao.Min / 60);

            Console.WriteLine("Valor à pagar: R$" + valor_total);
        }
    }
}