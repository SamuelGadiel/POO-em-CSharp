using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laboratorio06
{
    public partial class Form1 : Form
    {
        private bool arquivoAberto = false;
        private bool jaSalvo = false;

        public Form1() { InitializeComponent(); }

        private void salvarDados()
        {
            if (arquivoAberto == true)
            {
                try
                {
                    StreamWriter stream = new StreamWriter(ofd.FileName);
                    stream.WriteLine(txtDados.Text);

                    stream.Close();

                    jaSalvo = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não há um arquivo aberto", "Erro!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Arquivo não aberto", "Erro!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = ofd.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                try
                {
                    Stream dataFile = ofd.OpenFile();
                    StreamReader stream = new StreamReader(dataFile, Encoding.UTF8);

                    //StreamReader stream = new StreamReader(dataFile, Encoding.GetEncoding("iso-8859-1"));
                    txtDados.Text = stream.ReadToEnd();

                    stream.Close();

                    lblNome.Text = "Nome: " + ofd.SafeFileName;

                    arquivoAberto = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possivel abrir o arquivo", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvarDados();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(arquivoAberto == true && jaSalvo == false)
            {
                DialogResult result = MessageBox.Show("Deseja salvar as alterações?",
                "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        salvarDados();
                    }
                    catch (Exception) { }
                }

                if (result == DialogResult.No) { }
            }
        }
    }
}
