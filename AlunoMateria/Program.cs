using System;
using System.Collections.Generic;

namespace alunoMateria
{
    class MainClass
    {

        static Aluno achaAluno(String nome_aluno, List<Aluno> alunos)
        {
            Aluno achei_aluno = null;
            for(int i = 0; i < alunos.Count; i++)
            {
                if(nome_aluno == alunos[i].Nome)
                {
                    achei_aluno = alunos[i];
                    break;
                }
            }
            return achei_aluno;
        }

        static Materia achaMateria(String nome_materia, List<Materia> materias)
        {
            Materia achei_materia = null;
            for (int i = 0; i < materias.Count; i++)
            {
                if (nome_materia == materias[i].Nome)
                {
                    achei_materia = materias[i];
                    break;
                }
            }
            return achei_materia;
        }

        public static void Main(string[] args)
        {
            /*
            Aluno aluno01 = new Aluno("Samuel Gadiel","11721EAU005", 5);
            Aluno aluno02 = new Aluno("Sara", "11911TST005", 5);

            Materia materia01 = new Materia("POO", "0001");
            Materia materia02 = new Materia("ESC", "0002");
            Materia materia03 = new Materia("EDG", "0003");

            aluno01.associaMateria(materia01);
            aluno01.associaMateria(materia02);
            aluno01.associaMateria(materia03);

            aluno02.associaMateria(materia01);
            aluno02.associaMateria(materia02);
            aluno02.associaMateria(materia03);

            Console.WriteLine("Aluno 1");
            aluno01.imprimeRelatorio();

            Console.WriteLine("Aluno 2");
            aluno02.imprimeRelatorio();
            */




            List<Aluno> listaAlunos = new List<Aluno>();
            List<Materia> listaMaterias = new List<Materia>();

            Aluno aL;
            Materia mL;

            int aux = 1;
            while(aux != 0)
            {
                Console.WriteLine("-----Escolha uma opção-----");
                Console.WriteLine("[1] - Cadastrar Aluno");
                Console.WriteLine("[2] - Cadastrar uma disciplina");
                Console.WriteLine("[3] - Associar uma disciplina a um aluno");
                Console.WriteLine("[4] - Imprimir relatório");
                Console.WriteLine("[5] - Sair");

                String op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("Nome do aluno: ");
                        String nome_aluno = Console.ReadLine();
                        Console.Write("Matricula: ");
                        String matricula = Console.ReadLine();
                        Console.Write("Periodo: ");
                        int periodo = Convert.ToInt32(Console.ReadLine());

                        Aluno aluno = new Aluno(nome_aluno, matricula, periodo);
                        listaAlunos.Add(aluno);

                        Console.Clear();

                        break;

                    case "2":
                        Console.Write("Nome da matéria: ");
                        String nome_materia = Console.ReadLine();
                        Console.Write("Código de matéria: ");
                        String codigo = Console.ReadLine();

                        Materia materia = new Materia(nome_materia, codigo);
                        listaMaterias.Add(materia);

                        Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("Escolha um Aluno\n");

                        for(int i = 0; i < listaAlunos.Count; i++)
                        {
                            Aluno temp = (Aluno)listaAlunos[i];
                            Console.WriteLine("Aluno: " + temp.Nome);
                        }

                        nome_aluno = Console.ReadLine();
                        aL = achaAluno(nome_aluno, listaAlunos);

                        Console.WriteLine("Escolha uma Matéria");
                        for(int i = 0; i < listaMaterias.Count; i++)
                        {
                            Materia temp = (Materia)listaMaterias[i];
                            Console.WriteLine("Materia: " + temp.Nome);
                        }

                        nome_materia = Console.ReadLine();
                        mL = achaMateria(nome_materia, listaMaterias);

                        aL.associaMateria(mL);
                        Console.Clear();

                        break;

                    case "4":
                        for(int i = 0; i < listaAlunos.Count; i++)
                        {
                            Aluno temp = (Aluno)listaAlunos[i];
                            Console.WriteLine("Aluno: " + temp.Nome);
                        }

                        nome_aluno = Console.ReadLine();
                        aL = achaAluno(nome_aluno, listaAlunos);
                        aL.imprimeRelatorio();

                        Console.ReadLine();

                        Console.Clear();
                        break;

                    case "5":
                        aux = 0;

                        Console.Clear();
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
