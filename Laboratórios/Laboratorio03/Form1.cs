using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using alunoMateria;

namespace Laboratorio03
{
    public partial class Form1 : Form
    {
        // Atributos
        List<Aluno> listaAlunos = new List<Aluno>();
        List<Materia> listaMaterias = new List<Materia>();

        List<Label> txtMaterias = new List<Label>();
        List<Label> txtCodigos = new List<Label>();
        List<Array> textos = new List<Array>();

        // Construtor
        public Form1()
        {
            InitializeComponent();

            //textos.Add([materia1, codigo1]);


            txtMaterias.Add(txtMateria1);
            txtMaterias.Add(txtMateria2);
            txtMaterias.Add(txtMateria3);
            txtMaterias.Add(txtMateria4);
            txtMaterias.Add(txtMateria5);
            txtMaterias.Add(txtMateria6);
            txtMaterias.Add(txtMateria7);
            txtMaterias.Add(txtMateria8);

            txtCodigos.Add(txtCodigo1);
            txtCodigos.Add(txtCodigo2);
            txtCodigos.Add(txtCodigo3);
            txtCodigos.Add(txtCodigo4);
            txtCodigos.Add(txtCodigo5);
            txtCodigos.Add(txtCodigo6);
            txtCodigos.Add(txtCodigo7);
            txtCodigos.Add(txtCodigo8);
        }

        // Metodos

        static Aluno achaAluno(String nome_aluno, List<Aluno> alunos)
        {
            Aluno achei_aluno = null;
            for (int i = 0; i < alunos.Count; i++)
            {
                if (nome_aluno == alunos[i].Nome)
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


        private void btnSalvarA_Click(object sender, EventArgs e)
        {
            String nomeAluno = txtNomeA.Text;
            String matricula = txtMatriculaA.Text;
            int periodo = Convert.ToInt32(txtPeriodoA.Text);

            Aluno aluno = new Aluno(nomeAluno, matricula, periodo);

            listaAlunos.Add(aluno);

            lstAlunos.Items.Add(aluno.Nome);
            lstAlunosRelatorio.Items.Add(aluno.Nome);

            txtNomeA.Clear();
            txtMatriculaA.Clear();
            txtPeriodoA.Clear();
            txtNomeA.Focus();

        }

        private void btnSalvarM_Click(object sender, EventArgs e)
        {
            String nomeMateria = txtNomeM.Text;
            String codigo = txtCodigoM.Text;

            Materia materia = new Materia(nomeMateria, codigo);

            listaMaterias.Add(materia);

            lstMaterias.Items.Add(materia.Nome);

            txtNomeM.Clear();
            txtCodigoM.Clear();
            txtNomeM.Focus();
        }

        private void btnAssocia_Click(object sender, EventArgs e)
        {

            String aux, aluno_selecionado;
            Aluno auxAluno = new Aluno();
            Materia auxMateria = new Materia();

            aluno_selecionado = lstAlunos.GetItemText(lstAlunos.SelectedItem);

            auxAluno = achaAluno(aluno_selecionado, listaAlunos);
            /*
            for(int i = 0; i < listaAlunos.Count; i++)
            {
                if(listaAlunos[i].Nome == aluno_selecionado)
                {
                    auxAluno = listaAlunos[i];
                    break;
                }
            }
            */
            
            for (int i = 0; i < lstMaterias.Items.Count; i++)
            {
                if (lstMaterias.GetSelected(i))
                {
                    aux = lstMaterias.GetItemText(lstMaterias.SelectedItem);
                    

                    auxMateria = achaMateria(aux, listaMaterias);
                    auxAluno.associaMateria(auxMateria);
                    lstMaterias.SetSelected(i, false);
                    /*
                    for (int j = 0; j < listaMaterias.Count; j++)
                    {
                        if(listaMaterias[j].Nome == aux)
                        {
                            auxAluno.associaMateria(listaMaterias[j]);
                            break;
                        }
                    }
                    */
                }
            }
            lstAlunos.ClearSelected();

        }

        private void lstAlunosRelatorio_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lstAlunosRelatorio.IndexFromPoint(e.Location);
            int i = 0;
            String aux;
            Aluno auxAluno;

            if (index != ListBox.NoMatches)
            {
                for (i = 0; i< txtMaterias.Count; i++)
                {
                    txtMaterias[i].ResetText();
                    txtCodigos[i].ResetText();
                }
                aux = lstAlunosRelatorio.GetItemText(lstAlunosRelatorio.SelectedItem);

                auxAluno = achaAluno(aux, listaAlunos);


                txtAluno1.Text = auxAluno.Nome;
                txtAluno2.Text = auxAluno.Matricula;
                txtAluno3.Text = auxAluno.Periodo.ToString();

                i = 0;
                foreach(Materia aux_materia in auxAluno.ListaMaterias)
                {

                    if (aux_materia != null)
                    {
                        
                        txtMaterias[i].Text = aux_materia.Nome;
                        txtCodigos[i].Text = aux_materia.Codigo;
                        i++;
                    }
                    else
                        break;
                }
                
                if (painel.Visible == false)
                {
                    painel.Visible = true;
                }

            }
        }

        private void tabControl1_Deselected(object sender, TabControlEventArgs e)
        {
            txtNomeA.Clear();
            txtMatriculaA.Clear();
            txtPeriodoA.Clear();
            txtNomeM.Clear();
            txtCodigoM.Clear();
        }
    }
}
