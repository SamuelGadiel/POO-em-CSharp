namespace Laboratorio05
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnHorista = new System.Windows.Forms.RadioButton();
            this.rbtnCLT = new System.Windows.Forms.RadioButton();
            this.pnHorista = new System.Windows.Forms.Panel();
            this.txtPrecoHoras = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnCLT = new System.Windows.Forms.Panel();
            this.txtSalBruto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.painel = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDado2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDado1 = new System.Windows.Forms.Label();
            this.lblTipo1 = new System.Windows.Forms.Label();
            this.lblTipo2 = new System.Windows.Forms.Label();
            this.lblEnredeco = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstEmpregados = new System.Windows.Forms.ListBox();
            this.lblDado3 = new System.Windows.Forms.Label();
            this.lblTipo3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnHorista.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnCLT.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.painel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnHorista);
            this.groupBox1.Controls.Add(this.rbtnCLT);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(260, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 110);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Empregado";
            // 
            // rbtnHorista
            // 
            this.rbtnHorista.AutoSize = true;
            this.rbtnHorista.Location = new System.Drawing.Point(16, 64);
            this.rbtnHorista.Name = "rbtnHorista";
            this.rbtnHorista.Size = new System.Drawing.Size(58, 17);
            this.rbtnHorista.TabIndex = 1;
            this.rbtnHorista.TabStop = true;
            this.rbtnHorista.Text = "Horista";
            this.rbtnHorista.UseVisualStyleBackColor = true;
            this.rbtnHorista.CheckedChanged += new System.EventHandler(this.rbtnHorista_CheckedChanged);
            // 
            // rbtnCLT
            // 
            this.rbtnCLT.AutoSize = true;
            this.rbtnCLT.Location = new System.Drawing.Point(16, 32);
            this.rbtnCLT.Name = "rbtnCLT";
            this.rbtnCLT.Size = new System.Drawing.Size(45, 17);
            this.rbtnCLT.TabIndex = 0;
            this.rbtnCLT.TabStop = true;
            this.rbtnCLT.Text = "CLT";
            this.rbtnCLT.UseVisualStyleBackColor = true;
            this.rbtnCLT.CheckedChanged += new System.EventHandler(this.rbtnCLT_CheckedChanged);
            // 
            // pnHorista
            // 
            this.pnHorista.Controls.Add(this.txtPrecoHoras);
            this.pnHorista.Controls.Add(this.txtHoras);
            this.pnHorista.Controls.Add(this.label5);
            this.pnHorista.Controls.Add(this.label4);
            this.pnHorista.Location = new System.Drawing.Point(12, 112);
            this.pnHorista.Name = "pnHorista";
            this.pnHorista.Size = new System.Drawing.Size(240, 72);
            this.pnHorista.TabIndex = 6;
            this.pnHorista.Visible = false;
            // 
            // txtPrecoHoras
            // 
            this.txtPrecoHoras.Location = new System.Drawing.Point(80, 38);
            this.txtPrecoHoras.Name = "txtPrecoHoras";
            this.txtPrecoHoras.Size = new System.Drawing.Size(144, 20);
            this.txtPrecoHoras.TabIndex = 3;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(80, 6);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(144, 20);
            this.txtHoras.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Preço Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Horas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEndereco);
            this.panel2.Controls.Add(this.txtCPF);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 104);
            this.panel2.TabIndex = 4;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(80, 76);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(144, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(80, 44);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(144, 20);
            this.txtCPF.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(144, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(284, 130);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(417, 335);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnHorista);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.btnSalvar);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.pnCLT);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(409, 309);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Cadastro";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnCLT
            // 
            this.pnCLT.Controls.Add(this.txtSalBruto);
            this.pnCLT.Controls.Add(this.label6);
            this.pnCLT.Location = new System.Drawing.Point(12, 112);
            this.pnCLT.Name = "pnCLT";
            this.pnCLT.Size = new System.Drawing.Size(240, 48);
            this.pnCLT.TabIndex = 6;
            this.pnCLT.Visible = false;
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Location = new System.Drawing.Point(80, 6);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(144, 20);
            this.txtSalBruto.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Salário Bruto";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.painel);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.lstEmpregados);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(409, 309);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Relatório";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // painel
            // 
            this.painel.Controls.Add(this.lblDado3);
            this.painel.Controls.Add(this.lblTipo3);
            this.painel.Controls.Add(this.lblTipo);
            this.painel.Controls.Add(this.label8);
            this.painel.Controls.Add(this.label9);
            this.painel.Controls.Add(this.label10);
            this.painel.Controls.Add(this.label11);
            this.painel.Controls.Add(this.lblDado2);
            this.painel.Controls.Add(this.label12);
            this.painel.Controls.Add(this.lblDado1);
            this.painel.Controls.Add(this.lblTipo1);
            this.painel.Controls.Add(this.lblTipo2);
            this.painel.Controls.Add(this.lblEnredeco);
            this.painel.Controls.Add(this.lblCPF);
            this.painel.Controls.Add(this.lblNome);
            this.painel.Location = new System.Drawing.Point(176, 8);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(224, 288);
            this.painel.TabIndex = 31;
            this.painel.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTipo.Location = new System.Drawing.Point(96, 104);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 13);
            this.lblTipo.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(72, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "EMPREGADO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(0, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nome:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(0, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "CPF:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(0, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Endereço:";
            // 
            // lblDado2
            // 
            this.lblDado2.AutoSize = true;
            this.lblDado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDado2.Location = new System.Drawing.Point(96, 152);
            this.lblDado2.Name = "lblDado2";
            this.lblDado2.Size = new System.Drawing.Size(0, 13);
            this.lblDado2.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(0, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Tipo:";
            // 
            // lblDado1
            // 
            this.lblDado1.AutoSize = true;
            this.lblDado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDado1.Location = new System.Drawing.Point(96, 128);
            this.lblDado1.Name = "lblDado1";
            this.lblDado1.Size = new System.Drawing.Size(0, 13);
            this.lblDado1.TabIndex = 23;
            // 
            // lblTipo1
            // 
            this.lblTipo1.AutoSize = true;
            this.lblTipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTipo1.Location = new System.Drawing.Point(0, 128);
            this.lblTipo1.Name = "lblTipo1";
            this.lblTipo1.Size = new System.Drawing.Size(0, 13);
            this.lblTipo1.TabIndex = 11;
            // 
            // lblTipo2
            // 
            this.lblTipo2.AutoSize = true;
            this.lblTipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTipo2.Location = new System.Drawing.Point(0, 152);
            this.lblTipo2.Name = "lblTipo2";
            this.lblTipo2.Size = new System.Drawing.Size(0, 13);
            this.lblTipo2.TabIndex = 12;
            // 
            // lblEnredeco
            // 
            this.lblEnredeco.AutoSize = true;
            this.lblEnredeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnredeco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnredeco.Location = new System.Drawing.Point(96, 80);
            this.lblEnredeco.Name = "lblEnredeco";
            this.lblEnredeco.Size = new System.Drawing.Size(0, 13);
            this.lblEnredeco.TabIndex = 21;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCPF.Location = new System.Drawing.Point(96, 56);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(0, 13);
            this.lblCPF.TabIndex = 20;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNome.Location = new System.Drawing.Point(96, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 13);
            this.lblNome.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Empregados";
            // 
            // lstEmpregados
            // 
            this.lstEmpregados.FormattingEnabled = true;
            this.lstEmpregados.Location = new System.Drawing.Point(8, 32);
            this.lstEmpregados.Name = "lstEmpregados";
            this.lstEmpregados.Size = new System.Drawing.Size(160, 264);
            this.lstEmpregados.TabIndex = 0;
            this.lstEmpregados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstEmpregados_MouseClick);
            // 
            // lblDado3
            // 
            this.lblDado3.AutoSize = true;
            this.lblDado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDado3.Location = new System.Drawing.Point(96, 176);
            this.lblDado3.Name = "lblDado3";
            this.lblDado3.Size = new System.Drawing.Size(0, 13);
            this.lblDado3.TabIndex = 29;
            // 
            // lblTipo3
            // 
            this.lblTipo3.AutoSize = true;
            this.lblTipo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTipo3.Location = new System.Drawing.Point(0, 176);
            this.lblTipo3.Name = "lblTipo3";
            this.lblTipo3.Size = new System.Drawing.Size(0, 13);
            this.lblTipo3.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 335);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Laboratório 05 - Polimorfismo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnHorista.ResumeLayout(false);
            this.pnHorista.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnCLT.ResumeLayout(false);
            this.pnCLT.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnHorista;
        private System.Windows.Forms.RadioButton rbtnCLT;
        private System.Windows.Forms.Panel pnHorista;
        private System.Windows.Forms.TextBox txtPrecoHoras;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstEmpregados;
        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDado2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDado1;
        private System.Windows.Forms.Label lblTipo1;
        private System.Windows.Forms.Label lblTipo2;
        private System.Windows.Forms.Label lblEnredeco;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnCLT;
        private System.Windows.Forms.TextBox txtSalBruto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDado3;
        private System.Windows.Forms.Label lblTipo3;
    }
}

