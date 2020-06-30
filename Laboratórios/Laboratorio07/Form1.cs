using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio07
{
    public partial class Form1 : Form
    {
        Pilha pilha = new Pilha();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            txtPop.Clear();
            try
            {
                int numPush = Convert.ToInt32(txtPush.Text);

                pilha.Push(numPush);

                txtPush.Clear();
                txtPush.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Caráctere inválido!\nDeve ser um tipo inteiro.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            txtPop.Clear();
            string resultado;
            resultado = pilha.Print();

            txtPilha.Clear();
            txtPilha.Text = resultado;
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            txtPop.Clear();
            int? a = pilha.Pop();
            txtPop.Text = a.ToString();

            string resultado;
            resultado = pilha.Print();

            txtPilha.Clear();
            txtPilha.Text = resultado;
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            txtPop.Clear();
            int? maior;
            maior = pilha.Maior();

            txtPilha.Clear();
            txtPilha.Text = maior.ToString();
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            txtPop.Clear();
            int? menor;
            menor = pilha.Menor();

            txtPilha.Clear();
            txtPilha.Text = menor.ToString();
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            
            txtPop.Clear();
            Pilha resultado;
            string dadoPrint = null;

            resultado = pilha.Inverte();
            pilha = resultado;
            dadoPrint = pilha.Print();

            txtPilha.Clear();
            txtPilha.Text = dadoPrint;
        }
    }
}
