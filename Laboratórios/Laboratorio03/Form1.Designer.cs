using System;
using System.Collections.Generic;

namespace Laboratorio03
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvarA = new System.Windows.Forms.Button();
            this.txtPeriodoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatriculaA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvarM = new System.Windows.Forms.Button();
            this.txtCodigoM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAssocia = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstMaterias = new System.Windows.Forms.ListBox();
            this.lstAlunos = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.lstAlunosRelatorio = new System.Windows.Forms.ListBox();
            this.painel = new System.Windows.Forms.Panel();
            this.codigo8 = new System.Windows.Forms.Label();
            this.codigo7 = new System.Windows.Forms.Label();
            this.codigo2 = new System.Windows.Forms.Label();
            this.codigo5 = new System.Windows.Forms.Label();
            this.codigo3 = new System.Windows.Forms.Label();
            this.codigo6 = new System.Windows.Forms.Label();
            this.codigo4 = new System.Windows.Forms.Label();
            this.txtCodigo8 = new System.Windows.Forms.Label();
            this.txtCodigo7 = new System.Windows.Forms.Label();
            this.txtCodigo6 = new System.Windows.Forms.Label();
            this.txtCodigo5 = new System.Windows.Forms.Label();
            this.txtCodigo4 = new System.Windows.Forms.Label();
            this.txtCodigo3 = new System.Windows.Forms.Label();
            this.txtCodigo2 = new System.Windows.Forms.Label();
            this.codigo1 = new System.Windows.Forms.Label();
            this.txtCodigo1 = new System.Windows.Forms.Label();
            this.txtMateria8 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtMateria7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMateria6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMateria5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMateria4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMateria3 = new System.Windows.Forms.Label();
            this.materia1 = new System.Windows.Forms.Label();
            this.txtMateria2 = new System.Windows.Forms.Label();
            this.materia2 = new System.Windows.Forms.Label();
            this.txtMateria1 = new System.Windows.Forms.Label();
            this.materia3 = new System.Windows.Forms.Label();
            this.txtAluno3 = new System.Windows.Forms.Label();
            this.materia4 = new System.Windows.Forms.Label();
            this.txtAluno2 = new System.Windows.Forms.Label();
            this.materia5 = new System.Windows.Forms.Label();
            this.txtAluno1 = new System.Windows.Forms.Label();
            this.materia6 = new System.Windows.Forms.Label();
            this.materia8 = new System.Windows.Forms.Label();
            this.materia7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.painel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(501, 358);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Deselected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Deselected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnSalvarA);
            this.tabPage1.Controls.Add(this.txtPeriodoA);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtMatriculaA);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNomeA);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(493, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aluno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cadastro de Aluno";
            // 
            // btnSalvarA
            // 
            this.btnSalvarA.Location = new System.Drawing.Point(213, 198);
            this.btnSalvarA.Name = "btnSalvarA";
            this.btnSalvarA.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarA.TabIndex = 6;
            this.btnSalvarA.Text = "Salvar";
            this.btnSalvarA.UseVisualStyleBackColor = true;
            this.btnSalvarA.Click += new System.EventHandler(this.btnSalvarA_Click);
            // 
            // txtPeriodoA
            // 
            this.txtPeriodoA.Location = new System.Drawing.Point(230, 140);
            this.txtPeriodoA.Name = "txtPeriodoA";
            this.txtPeriodoA.Size = new System.Drawing.Size(138, 20);
            this.txtPeriodoA.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Período";
            // 
            // txtMatriculaA
            // 
            this.txtMatriculaA.Location = new System.Drawing.Point(230, 100);
            this.txtMatriculaA.Name = "txtMatriculaA";
            this.txtMatriculaA.Size = new System.Drawing.Size(138, 20);
            this.txtMatriculaA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matrícula";
            // 
            // txtNomeA
            // 
            this.txtNomeA.Location = new System.Drawing.Point(230, 58);
            this.txtNomeA.Name = "txtNomeA";
            this.txtNomeA.Size = new System.Drawing.Size(138, 20);
            this.txtNomeA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Aluno";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnSalvarM);
            this.tabPage2.Controls.Add(this.txtCodigoM);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtNomeM);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(493, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matéria";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cadastro de Matéria";
            // 
            // btnSalvarM
            // 
            this.btnSalvarM.Location = new System.Drawing.Point(213, 198);
            this.btnSalvarM.Name = "btnSalvarM";
            this.btnSalvarM.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarM.TabIndex = 14;
            this.btnSalvarM.Text = "Salvar";
            this.btnSalvarM.UseVisualStyleBackColor = true;
            this.btnSalvarM.Click += new System.EventHandler(this.btnSalvarM_Click);
            // 
            // txtCodigoM
            // 
            this.txtCodigoM.Location = new System.Drawing.Point(230, 118);
            this.txtCodigoM.Name = "txtCodigoM";
            this.txtCodigoM.Size = new System.Drawing.Size(138, 20);
            this.txtCodigoM.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Código";
            // 
            // txtNomeM
            // 
            this.txtNomeM.Location = new System.Drawing.Point(230, 76);
            this.txtNomeM.Name = "txtNomeM";
            this.txtNomeM.Size = new System.Drawing.Size(138, 20);
            this.txtNomeM.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nome do Matéria";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAssocia);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.lstMaterias);
            this.tabPage3.Controls.Add(this.lstAlunos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(493, 332);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Associa";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAssocia
            // 
            this.btnAssocia.Location = new System.Drawing.Point(393, 177);
            this.btnAssocia.Name = "btnAssocia";
            this.btnAssocia.Size = new System.Drawing.Size(75, 23);
            this.btnAssocia.TabIndex = 4;
            this.btnAssocia.Text = "Associar";
            this.btnAssocia.UseVisualStyleBackColor = true;
            this.btnAssocia.Click += new System.EventHandler(this.btnAssocia_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Matérias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Alunos";
            // 
            // lstMaterias
            // 
            this.lstMaterias.FormattingEnabled = true;
            this.lstMaterias.Location = new System.Drawing.Point(199, 32);
            this.lstMaterias.Name = "lstMaterias";
            this.lstMaterias.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstMaterias.Size = new System.Drawing.Size(176, 290);
            this.lstMaterias.TabIndex = 1;
            // 
            // lstAlunos
            // 
            this.lstAlunos.FormattingEnabled = true;
            this.lstAlunos.Location = new System.Drawing.Point(8, 32);
            this.lstAlunos.Name = "lstAlunos";
            this.lstAlunos.Size = new System.Drawing.Size(176, 290);
            this.lstAlunos.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.lstAlunosRelatorio);
            this.tabPage4.Controls.Add(this.painel);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage4.Size = new System.Drawing.Size(493, 332);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Relatório";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Alunos";
            // 
            // lstAlunosRelatorio
            // 
            this.lstAlunosRelatorio.FormattingEnabled = true;
            this.lstAlunosRelatorio.Location = new System.Drawing.Point(8, 32);
            this.lstAlunosRelatorio.Name = "lstAlunosRelatorio";
            this.lstAlunosRelatorio.Size = new System.Drawing.Size(176, 290);
            this.lstAlunosRelatorio.TabIndex = 3;
            this.lstAlunosRelatorio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstAlunosRelatorio_MouseClick);
            // 
            // painel
            // 
            this.painel.Controls.Add(this.codigo8);
            this.painel.Controls.Add(this.codigo7);
            this.painel.Controls.Add(this.codigo2);
            this.painel.Controls.Add(this.codigo5);
            this.painel.Controls.Add(this.codigo3);
            this.painel.Controls.Add(this.codigo6);
            this.painel.Controls.Add(this.codigo4);
            this.painel.Controls.Add(this.txtCodigo8);
            this.painel.Controls.Add(this.txtCodigo7);
            this.painel.Controls.Add(this.txtCodigo6);
            this.painel.Controls.Add(this.txtCodigo5);
            this.painel.Controls.Add(this.txtCodigo4);
            this.painel.Controls.Add(this.txtCodigo3);
            this.painel.Controls.Add(this.txtCodigo2);
            this.painel.Controls.Add(this.codigo1);
            this.painel.Controls.Add(this.txtCodigo1);
            this.painel.Controls.Add(this.txtMateria8);
            this.painel.Controls.Add(this.label23);
            this.painel.Controls.Add(this.txtMateria7);
            this.painel.Controls.Add(this.label14);
            this.painel.Controls.Add(this.txtMateria6);
            this.painel.Controls.Add(this.label11);
            this.painel.Controls.Add(this.txtMateria5);
            this.painel.Controls.Add(this.label12);
            this.painel.Controls.Add(this.txtMateria4);
            this.painel.Controls.Add(this.label13);
            this.painel.Controls.Add(this.txtMateria3);
            this.painel.Controls.Add(this.materia1);
            this.painel.Controls.Add(this.txtMateria2);
            this.painel.Controls.Add(this.materia2);
            this.painel.Controls.Add(this.txtMateria1);
            this.painel.Controls.Add(this.materia3);
            this.painel.Controls.Add(this.txtAluno3);
            this.painel.Controls.Add(this.materia4);
            this.painel.Controls.Add(this.txtAluno2);
            this.painel.Controls.Add(this.materia5);
            this.painel.Controls.Add(this.txtAluno1);
            this.painel.Controls.Add(this.materia6);
            this.painel.Controls.Add(this.materia8);
            this.painel.Controls.Add(this.materia7);
            this.painel.Location = new System.Drawing.Point(208, 8);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(272, 312);
            this.painel.TabIndex = 30;
            this.painel.Visible = false;
            // 
            // codigo8
            // 
            this.codigo8.AutoSize = true;
            this.codigo8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.codigo8.Location = new System.Drawing.Point(168, 288);
            this.codigo8.Name = "codigo8";
            this.codigo8.Size = new System.Drawing.Size(50, 13);
            this.codigo8.TabIndex = 52;
            this.codigo8.Text = "Código:";
            // 
            // codigo7
            // 
            this.codigo7.AutoSize = true;
            this.codigo7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.codigo7.Location = new System.Drawing.Point(168, 264);
            this.codigo7.Name = "codigo7";
            this.codigo7.Size = new System.Drawing.Size(50, 13);
            this.codigo7.TabIndex = 51;
            this.codigo7.Text = "Código:";
            // 
            // codigo2
            // 
            this.codigo2.AutoSize = true;
            this.codigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.codigo2.Location = new System.Drawing.Point(168, 144);
            this.codigo2.Name = "codigo2";
            this.codigo2.Size = new System.Drawing.Size(50, 13);
            this.codigo2.TabIndex = 50;
            this.codigo2.Text = "Código:";
            // 
            // codigo5
            // 
            this.codigo5.AutoSize = true;
            this.codigo5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.codigo5.Location = new System.Drawing.Point(168, 216);
            this.codigo5.Name = "codigo5";
            this.codigo5.Size = new System.Drawing.Size(50, 13);
            this.codigo5.TabIndex = 49;
            this.codigo5.Text = "Código:";
            // 
            // codigo3
            // 
            this.codigo3.AutoSize = true;
            this.codigo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.codigo3.Location = new System.Drawing.Point(168, 168);
            this.codigo3.Name = "codigo3";
            this.codigo3.Size = new System.Drawing.Size(50, 13);
            this.codigo3.TabIndex = 48;
            this.codigo3.Text = "Código:";
            // 
            // codigo6
            // 
            this.codigo6.AutoSize = true;
            this.codigo6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.codigo6.Location = new System.Drawing.Point(168, 240);
            this.codigo6.Name = "codigo6";
            this.codigo6.Size = new System.Drawing.Size(50, 13);
            this.codigo6.TabIndex = 47;
            this.codigo6.Text = "Código:";
            // 
            // codigo4
            // 
            this.codigo4.AutoSize = true;
            this.codigo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.codigo4.Location = new System.Drawing.Point(168, 192);
            this.codigo4.Name = "codigo4";
            this.codigo4.Size = new System.Drawing.Size(50, 13);
            this.codigo4.TabIndex = 46;
            this.codigo4.Text = "Código:";
            // 
            // txtCodigo8
            // 
            this.txtCodigo8.AutoSize = true;
            this.txtCodigo8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigo8.Location = new System.Drawing.Point(224, 288);
            this.txtCodigo8.Name = "txtCodigo8";
            this.txtCodigo8.Size = new System.Drawing.Size(0, 13);
            this.txtCodigo8.TabIndex = 45;
            // 
            // txtCodigo7
            // 
            this.txtCodigo7.AutoSize = true;
            this.txtCodigo7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigo7.Location = new System.Drawing.Point(224, 264);
            this.txtCodigo7.Name = "txtCodigo7";
            this.txtCodigo7.Size = new System.Drawing.Size(0, 13);
            this.txtCodigo7.TabIndex = 43;
            // 
            // txtCodigo6
            // 
            this.txtCodigo6.AutoSize = true;
            this.txtCodigo6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigo6.Location = new System.Drawing.Point(224, 240);
            this.txtCodigo6.Name = "txtCodigo6";
            this.txtCodigo6.Size = new System.Drawing.Size(0, 13);
            this.txtCodigo6.TabIndex = 41;
            // 
            // txtCodigo5
            // 
            this.txtCodigo5.AutoSize = true;
            this.txtCodigo5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigo5.Location = new System.Drawing.Point(224, 216);
            this.txtCodigo5.Name = "txtCodigo5";
            this.txtCodigo5.Size = new System.Drawing.Size(0, 13);
            this.txtCodigo5.TabIndex = 39;
            // 
            // txtCodigo4
            // 
            this.txtCodigo4.AutoSize = true;
            this.txtCodigo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigo4.Location = new System.Drawing.Point(224, 192);
            this.txtCodigo4.Name = "txtCodigo4";
            this.txtCodigo4.Size = new System.Drawing.Size(0, 13);
            this.txtCodigo4.TabIndex = 37;
            // 
            // txtCodigo3
            // 
            this.txtCodigo3.AutoSize = true;
            this.txtCodigo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigo3.Location = new System.Drawing.Point(224, 168);
            this.txtCodigo3.Name = "txtCodigo3";
            this.txtCodigo3.Size = new System.Drawing.Size(0, 13);
            this.txtCodigo3.TabIndex = 35;
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.AutoSize = true;
            this.txtCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigo2.Location = new System.Drawing.Point(224, 144);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(0, 13);
            this.txtCodigo2.TabIndex = 33;
            // 
            // codigo1
            // 
            this.codigo1.AutoSize = true;
            this.codigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.codigo1.Location = new System.Drawing.Point(168, 120);
            this.codigo1.Name = "codigo1";
            this.codigo1.Size = new System.Drawing.Size(50, 13);
            this.codigo1.TabIndex = 30;
            this.codigo1.Text = "Código:";
            // 
            // txtCodigo1
            // 
            this.txtCodigo1.AutoSize = true;
            this.txtCodigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodigo1.Location = new System.Drawing.Point(224, 120);
            this.txtCodigo1.Name = "txtCodigo1";
            this.txtCodigo1.Size = new System.Drawing.Size(0, 13);
            this.txtCodigo1.TabIndex = 31;
            // 
            // txtMateria8
            // 
            this.txtMateria8.AutoSize = true;
            this.txtMateria8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMateria8.Location = new System.Drawing.Point(80, 288);
            this.txtMateria8.Name = "txtMateria8";
            this.txtMateria8.Size = new System.Drawing.Size(0, 13);
            this.txtMateria8.TabIndex = 29;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label23.Location = new System.Drawing.Point(112, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 18;
            this.label23.Text = "ALUNO";
            // 
            // txtMateria7
            // 
            this.txtMateria7.AutoSize = true;
            this.txtMateria7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMateria7.Location = new System.Drawing.Point(80, 264);
            this.txtMateria7.Name = "txtMateria7";
            this.txtMateria7.Size = new System.Drawing.Size(0, 13);
            this.txtMateria7.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(104, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "MATÉRIAS";
            // 
            // txtMateria6
            // 
            this.txtMateria6.AutoSize = true;
            this.txtMateria6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMateria6.Location = new System.Drawing.Point(80, 240);
            this.txtMateria6.Name = "txtMateria6";
            this.txtMateria6.Size = new System.Drawing.Size(0, 13);
            this.txtMateria6.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(8, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nome:";
            // 
            // txtMateria5
            // 
            this.txtMateria5.AutoSize = true;
            this.txtMateria5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMateria5.Location = new System.Drawing.Point(80, 216);
            this.txtMateria5.Name = "txtMateria5";
            this.txtMateria5.Size = new System.Drawing.Size(0, 13);
            this.txtMateria5.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(8, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Matrícula:";
            // 
            // txtMateria4
            // 
            this.txtMateria4.AutoSize = true;
            this.txtMateria4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMateria4.Location = new System.Drawing.Point(80, 192);
            this.txtMateria4.Name = "txtMateria4";
            this.txtMateria4.Size = new System.Drawing.Size(0, 13);
            this.txtMateria4.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(8, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Período:";
            // 
            // txtMateria3
            // 
            this.txtMateria3.AutoSize = true;
            this.txtMateria3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMateria3.Location = new System.Drawing.Point(80, 168);
            this.txtMateria3.Name = "txtMateria3";
            this.txtMateria3.Size = new System.Drawing.Size(0, 13);
            this.txtMateria3.TabIndex = 24;
            // 
            // materia1
            // 
            this.materia1.AutoSize = true;
            this.materia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materia1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.materia1.Location = new System.Drawing.Point(8, 120);
            this.materia1.Name = "materia1";
            this.materia1.Size = new System.Drawing.Size(72, 13);
            this.materia1.TabIndex = 10;
            this.materia1.Text = "1 - Matéria:";
            // 
            // txtMateria2
            // 
            this.txtMateria2.AutoSize = true;
            this.txtMateria2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMateria2.Location = new System.Drawing.Point(80, 144);
            this.txtMateria2.Name = "txtMateria2";
            this.txtMateria2.Size = new System.Drawing.Size(0, 13);
            this.txtMateria2.TabIndex = 23;
            // 
            // materia2
            // 
            this.materia2.AutoSize = true;
            this.materia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materia2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.materia2.Location = new System.Drawing.Point(8, 144);
            this.materia2.Name = "materia2";
            this.materia2.Size = new System.Drawing.Size(72, 13);
            this.materia2.TabIndex = 11;
            this.materia2.Text = "2 - Matéria:";
            // 
            // txtMateria1
            // 
            this.txtMateria1.AutoSize = true;
            this.txtMateria1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMateria1.Location = new System.Drawing.Point(80, 120);
            this.txtMateria1.Name = "txtMateria1";
            this.txtMateria1.Size = new System.Drawing.Size(0, 13);
            this.txtMateria1.TabIndex = 22;
            // 
            // materia3
            // 
            this.materia3.AutoSize = true;
            this.materia3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materia3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.materia3.Location = new System.Drawing.Point(8, 168);
            this.materia3.Name = "materia3";
            this.materia3.Size = new System.Drawing.Size(72, 13);
            this.materia3.TabIndex = 12;
            this.materia3.Text = "3 - Matéria:";
            // 
            // txtAluno3
            // 
            this.txtAluno3.AutoSize = true;
            this.txtAluno3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluno3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAluno3.Location = new System.Drawing.Point(80, 72);
            this.txtAluno3.Name = "txtAluno3";
            this.txtAluno3.Size = new System.Drawing.Size(0, 13);
            this.txtAluno3.TabIndex = 21;
            // 
            // materia4
            // 
            this.materia4.AutoSize = true;
            this.materia4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materia4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.materia4.Location = new System.Drawing.Point(8, 192);
            this.materia4.Name = "materia4";
            this.materia4.Size = new System.Drawing.Size(72, 13);
            this.materia4.TabIndex = 13;
            this.materia4.Text = "4 - Matéria:";
            // 
            // txtAluno2
            // 
            this.txtAluno2.AutoSize = true;
            this.txtAluno2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluno2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAluno2.Location = new System.Drawing.Point(80, 48);
            this.txtAluno2.Name = "txtAluno2";
            this.txtAluno2.Size = new System.Drawing.Size(0, 13);
            this.txtAluno2.TabIndex = 20;
            // 
            // materia5
            // 
            this.materia5.AutoSize = true;
            this.materia5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materia5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.materia5.Location = new System.Drawing.Point(8, 216);
            this.materia5.Name = "materia5";
            this.materia5.Size = new System.Drawing.Size(72, 13);
            this.materia5.TabIndex = 14;
            this.materia5.Text = "5 - Matéria:";
            // 
            // txtAluno1
            // 
            this.txtAluno1.AutoSize = true;
            this.txtAluno1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluno1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAluno1.Location = new System.Drawing.Point(80, 24);
            this.txtAluno1.Name = "txtAluno1";
            this.txtAluno1.Size = new System.Drawing.Size(0, 13);
            this.txtAluno1.TabIndex = 19;
            // 
            // materia6
            // 
            this.materia6.AutoSize = true;
            this.materia6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materia6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.materia6.Location = new System.Drawing.Point(8, 240);
            this.materia6.Name = "materia6";
            this.materia6.Size = new System.Drawing.Size(72, 13);
            this.materia6.TabIndex = 15;
            this.materia6.Text = "6 - Matéria:";
            // 
            // materia8
            // 
            this.materia8.AutoSize = true;
            this.materia8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materia8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.materia8.Location = new System.Drawing.Point(8, 288);
            this.materia8.Name = "materia8";
            this.materia8.Size = new System.Drawing.Size(72, 13);
            this.materia8.TabIndex = 17;
            this.materia8.Text = "8 - Matéria:";
            // 
            // materia7
            // 
            this.materia7.AutoSize = true;
            this.materia7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materia7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.materia7.Location = new System.Drawing.Point(8, 264);
            this.materia7.Name = "materia7";
            this.materia7.Size = new System.Drawing.Size(72, 13);
            this.materia7.TabIndex = 16;
            this.materia7.Text = "7 - Matéria:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 358);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Cadastro Aluno/Matéria";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvarA;
        private System.Windows.Forms.TextBox txtPeriodoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatriculaA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvarM;
        private System.Windows.Forms.TextBox txtCodigoM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnAssocia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstMaterias;
        private System.Windows.Forms.ListBox lstAlunos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstAlunosRelatorio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label materia8;
        private System.Windows.Forms.Label materia7;
        private System.Windows.Forms.Label materia6;
        private System.Windows.Forms.Label materia5;
        private System.Windows.Forms.Label materia4;
        private System.Windows.Forms.Label materia3;
        private System.Windows.Forms.Label materia2;
        private System.Windows.Forms.Label materia1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtMateria8;
        private System.Windows.Forms.Label txtMateria7;
        private System.Windows.Forms.Label txtMateria6;
        private System.Windows.Forms.Label txtMateria5;
        private System.Windows.Forms.Label txtMateria4;
        private System.Windows.Forms.Label txtMateria3;
        private System.Windows.Forms.Label txtMateria2;
        private System.Windows.Forms.Label txtMateria1;
        private System.Windows.Forms.Label txtAluno3;
        private System.Windows.Forms.Label txtAluno2;
        private System.Windows.Forms.Label txtAluno1;
        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.Label codigo8;
        private System.Windows.Forms.Label codigo7;
        private System.Windows.Forms.Label codigo2;
        private System.Windows.Forms.Label codigo5;
        private System.Windows.Forms.Label codigo3;
        private System.Windows.Forms.Label codigo6;
        private System.Windows.Forms.Label codigo4;
        private System.Windows.Forms.Label txtCodigo8;
        private System.Windows.Forms.Label txtCodigo7;
        private System.Windows.Forms.Label txtCodigo6;
        private System.Windows.Forms.Label txtCodigo5;
        private System.Windows.Forms.Label txtCodigo4;
        private System.Windows.Forms.Label txtCodigo3;
        private System.Windows.Forms.Label txtCodigo2;
        private System.Windows.Forms.Label codigo1;
        private System.Windows.Forms.Label txtCodigo1;
    }
}

