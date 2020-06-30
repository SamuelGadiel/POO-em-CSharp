namespace Laboratorio07
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
            this.lblPilha = new System.Windows.Forms.Label();
            this.txtPilha = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnImprime = new System.Windows.Forms.Button();
            this.btnMaior = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.btnInverte = new System.Windows.Forms.Button();
            this.txtPush = new System.Windows.Forms.TextBox();
            this.txtPop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPilha
            // 
            this.lblPilha.AutoSize = true;
            this.lblPilha.Location = new System.Drawing.Point(8, 52);
            this.lblPilha.Name = "lblPilha";
            this.lblPilha.Size = new System.Drawing.Size(38, 13);
            this.lblPilha.TabIndex = 0;
            this.lblPilha.Text = "PILHA";
            // 
            // txtPilha
            // 
            this.txtPilha.Location = new System.Drawing.Point(56, 8);
            this.txtPilha.Multiline = true;
            this.txtPilha.Name = "txtPilha";
            this.txtPilha.Size = new System.Drawing.Size(152, 360);
            this.txtPilha.TabIndex = 1;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(240, 47);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 2;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(240, 103);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(75, 23);
            this.btnPop.TabIndex = 2;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnImprime
            // 
            this.btnImprime.Location = new System.Drawing.Point(240, 159);
            this.btnImprime.Name = "btnImprime";
            this.btnImprime.Size = new System.Drawing.Size(75, 23);
            this.btnImprime.TabIndex = 2;
            this.btnImprime.Text = "Imprime";
            this.btnImprime.UseVisualStyleBackColor = true;
            this.btnImprime.Click += new System.EventHandler(this.btnImprime_Click);
            // 
            // btnMaior
            // 
            this.btnMaior.Location = new System.Drawing.Point(240, 215);
            this.btnMaior.Name = "btnMaior";
            this.btnMaior.Size = new System.Drawing.Size(75, 23);
            this.btnMaior.TabIndex = 2;
            this.btnMaior.Text = "Maior";
            this.btnMaior.UseVisualStyleBackColor = true;
            this.btnMaior.Click += new System.EventHandler(this.btnMaior_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.Location = new System.Drawing.Point(240, 271);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(75, 23);
            this.btnMenor.TabIndex = 2;
            this.btnMenor.Text = "Menor";
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
            // 
            // btnInverte
            // 
            this.btnInverte.Location = new System.Drawing.Point(240, 327);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(75, 23);
            this.btnInverte.TabIndex = 2;
            this.btnInverte.Text = "Inverte";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.btnInverte_Click);
            // 
            // txtPush
            // 
            this.txtPush.Location = new System.Drawing.Point(328, 48);
            this.txtPush.Name = "txtPush";
            this.txtPush.Size = new System.Drawing.Size(64, 20);
            this.txtPush.TabIndex = 3;
            this.txtPush.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPop
            // 
            this.txtPop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPop.Location = new System.Drawing.Point(328, 104);
            this.txtPop.Name = "txtPop";
            this.txtPop.ReadOnly = true;
            this.txtPop.Size = new System.Drawing.Size(64, 20);
            this.txtPop.TabIndex = 3;
            this.txtPop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 374);
            this.Controls.Add(this.txtPop);
            this.Controls.Add(this.txtPush);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.btnMaior);
            this.Controls.Add(this.btnImprime);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtPilha);
            this.Controls.Add(this.lblPilha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPilha;
        private System.Windows.Forms.TextBox txtPilha;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnImprime;
        private System.Windows.Forms.Button btnMaior;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Button btnInverte;
        private System.Windows.Forms.TextBox txtPush;
        private System.Windows.Forms.TextBox txtPop;
    }
}

