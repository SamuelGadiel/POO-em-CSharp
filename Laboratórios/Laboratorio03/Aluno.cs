using System;
using System.Windows.Forms;

namespace alunoMateria
{
    public class Aluno
    {
        // Atributos
        private String nome;
        private String numero_matricula;
        private int periodo;

        private Materia[] lista_materias;
        private int TAMANHO = 8;
        public int counter;

        // Construtores
        public Aluno()
        {
            nome = "";
            numero_matricula = "";
            periodo = 0;
            lista_materias = new Materia[TAMANHO];
            counter = 0;
        }

        public Aluno(String _nome, String _numero_matricula, int _periodo)
        {
            nome = _nome;
            numero_matricula = _numero_matricula;
            periodo = _periodo;
            lista_materias = new Materia[TAMANHO];
            counter = 0;
        }

        // Getters e Setters
        public String Nome { get => nome; set => nome = value; }
        public String Matricula { get => numero_matricula; set => numero_matricula = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public Materia[] ListaMaterias { get => lista_materias; }


        public void associaMateria(Materia _materia)
        {
            if (counter < TAMANHO)
            {
                lista_materias[counter] = _materia;
                counter++;
            }
            else
            {
                MessageBox.Show("LIMITE DE MATERIAS ALCANÇADO");
            }
        }

        public void imprimeRelatorio()
        {

            for(int i = 0; i < counter; i++)
            {
                Console.WriteLine("Materia " + (i + 1) + ": " +  lista_materias[i].Nome);
            }
        }


    }
}
