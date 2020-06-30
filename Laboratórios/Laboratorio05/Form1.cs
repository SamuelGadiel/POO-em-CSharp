using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio05
{
    public partial class Form1 : Form
    {

        List<Empregado> empregados = new List<Empregado>();

        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnCLT_CheckedChanged(object sender, EventArgs e)
        {
            pnHorista.Hide();
            pnCLT.Show();

            txtHoras.Clear();
            txtPrecoHoras.Clear();
        }

        private void rbtnHorista_CheckedChanged(object sender, EventArgs e)
        {
            pnCLT.Hide();
            pnHorista.Show();

            txtSalBruto.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (rbtnCLT.Checked)
            {
                EmpregadoCLT empClt = new EmpregadoCLT();

                empClt.Nome = txtNome.Text;
                empClt.CPF = txtCPF.Text;
                empClt.Enredeco = txtEndereco.Text;
                empClt.SBrutoCLT = Convert.ToDouble(txtSalBruto.Text);

                empregados.Add(empClt);

                lstEmpregados.Items.Add(empClt.Nome);

                txtSalBruto.Clear();
                rbtnCLT.Checked = false;
                pnCLT.Hide();
            }
            else
            {
                EmpregadoHorista empHora = new EmpregadoHorista();

                empHora.Nome = txtNome.Text;
                empHora.CPF = txtCPF.Text;
                empHora.Enredeco = txtEndereco.Text;
                empHora.NHoras = Convert.ToInt32(txtHoras.Text);
                empHora.PrecoH = Convert.ToDouble(txtPrecoHoras.Text);

                empregados.Add(empHora);

                lstEmpregados.Items.Add(empHora.Nome);

                txtHoras.Clear();
                txtPrecoHoras.Clear();
                rbtnHorista.Checked = false;
                pnHorista.Hide();
            }

            txtNome.Clear();
            txtCPF.Clear();
            txtEndereco.Clear();
            
        }

        private void lstEmpregados_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lstEmpregados.IndexFromPoint(e.Location);
            String aux;
            Empregado auxEmpregado = null;

            if (index != ListBox.NoMatches)
            {
                aux = lstEmpregados.GetItemText(lstEmpregados.SelectedItem);

                for (int i = 0; i < empregados.Count(); i++)
                {
                    if(aux == empregados[i].Nome)
                    {
                        auxEmpregado = empregados[i];
                        break;
                    }
                }

                lblNome.Text = auxEmpregado.Nome;
                lblCPF.Text = auxEmpregado.CPF;
                lblEnredeco.Text = auxEmpregado.Enredeco;

                if (auxEmpregado is EmpregadoCLT)
                {
                    lblTipo.Text = "CLT";

                    lblTipo1.Text = "Salário Bruto:";
                    lblDado1.Text = ((EmpregadoCLT)auxEmpregado).SBrutoCLT.ToString();

                    lblTipo2.Text = "Salário Líquido:";
                    lblDado2.Text = ((EmpregadoCLT)auxEmpregado).salarioLiq().ToString();

                    lblTipo3.ResetText();
                    lblDado3.ResetText();
                }
                else if (auxEmpregado is EmpregadoHorista)
                {
                    lblTipo.Text = "Horista";

                    lblTipo1.Text = "Horas:";
                    lblDado1.Text = ((EmpregadoHorista)auxEmpregado).NHoras.ToString();

                    lblTipo2.Text = "Preço Horas:";
                    lblDado2.Text = ((EmpregadoHorista)auxEmpregado).PrecoH.ToString();

                    lblTipo3.Text = "Salário Líquido:";
                    lblDado3.Text = ((EmpregadoHorista)auxEmpregado).salarioLiq().ToString();
                }

                if (painel.Visible == false)
                {
                    painel.Visible = true;
                }
                
            }
        }
    }
}
