using System;
namespace Laboratorio02
{
    public class Tempo
    {
        // atributos
        private int hora;
        private int min;
        private int seg;

        // Construtores
        public Tempo()
        {
            hora = 0;
            min = 0;
            seg = 0;
        }

        public Tempo(int _hora, int _min, int _seg)
        {
            hora = _hora;
            min = _min;
            seg = _seg;
        }

        // Setters e Getters
        public int Hora { get => hora; set => hora = value; }
        public int Min { get => min; set => min = value; }
        public int Seg { get => seg; set => seg = value; }

        // Metodos
        public void AskForTime()
        {
            // Formato do horário: 'hh:mm:ss'
            String horario = Console.ReadLine();
            int _hora = Convert.ToInt32(horario.Substring(0, 2));
            int _min = Convert.ToInt32(horario.Substring(3, 2));
            int _seg = Convert.ToInt32(horario.Substring(6, 2));

            hora = _hora;
            min = _min;
            seg = _seg;
        }

        public void PrintTime()
        {
            Console.WriteLine(String.Format("{0:00}", hora) + ":" + String.Format("{0:00}", min) + ":" + String.Format("{0:00}", seg));
        }

        public Tempo AddTimes(Tempo _tempo)
        {
            Tempo aux = new Tempo();

            aux.seg = _tempo.seg + seg;
            aux.min = _tempo.min + min;
            aux.hora = _tempo.hora + hora;

            if (aux.seg >= 60)
            {
                aux.seg = aux.seg - 60;
                aux.min++;
            }

            if (aux.min >= 60)
            {
                aux.min = aux.min - 60;
                aux.hora++;
            }

            if (aux.hora > 23)
            {
                aux.hora = aux.hora - 24;
            }

            return aux;
        }

        public Tempo SubTimes(Tempo _tempo)
        {
            Tempo aux = new Tempo();

            aux.seg = seg - _tempo.seg;
            aux.min = min - _tempo.min;
            aux.hora = hora - _tempo.hora;

            if (aux.seg < 0)
            {
                aux.seg = 60 + aux.seg;
                aux.min--;
            }

            if (aux.min < 0)
            {
                aux.min = 60 + aux.min;
                aux.hora--;
            }

            if (aux.hora < 0)
            {
                aux.hora = 24 + aux.hora;
            }

            return aux;
        }

    }
}