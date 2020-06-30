using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var aluno = new Aluno();
            aluno.Nome = textNome.Text;
            aluno.AnoIngresso = (int)numericAno.Value;
            aluno.Inserir();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Aluno> alunos = Aluno.Listar();
            alunos.ToArray();
            for (int i = 0; i < alunos.Count; i++)
            {
                listaAlunos.Items.Add(alunos[i]);
            }
            
        }
    }
}
