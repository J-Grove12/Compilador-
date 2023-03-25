namespace Compilador
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLexico = new System.Windows.Forms.Button();
            this.btnSintatico = new System.Windows.Forms.Button();
            this.btnSemantico = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.txtTitle.Location = new System.Drawing.Point(12, 10);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(116, 22);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Compilador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estudiante Jonatan Chavarriaga";
            // 
            // btnLexico
            // 
            this.btnLexico.BackColor = System.Drawing.Color.White;
            this.btnLexico.ForeColor = System.Drawing.Color.Black;
            this.btnLexico.Location = new System.Drawing.Point(37, 95);
            this.btnLexico.Name = "btnLexico";
            this.btnLexico.Size = new System.Drawing.Size(75, 23);
            this.btnLexico.TabIndex = 2;
            this.btnLexico.Text = "Lexico";
            this.btnLexico.UseVisualStyleBackColor = false;
            this.btnLexico.Click += new System.EventHandler(this.btnLexico_Click);
            // 
            // btnSintatico
            // 
            this.btnSintatico.BackColor = System.Drawing.Color.White;
            this.btnSintatico.Location = new System.Drawing.Point(37, 136);
            this.btnSintatico.Name = "btnSintatico";
            this.btnSintatico.Size = new System.Drawing.Size(75, 23);
            this.btnSintatico.TabIndex = 3;
            this.btnSintatico.Text = "Sintatico";
            this.btnSintatico.UseVisualStyleBackColor = false;
            this.btnSintatico.Click += new System.EventHandler(this.btnSintatico_Click);
            // 
            // btnSemantico
            // 
            this.btnSemantico.BackColor = System.Drawing.Color.White;
            this.btnSemantico.Location = new System.Drawing.Point(37, 183);
            this.btnSemantico.Name = "btnSemantico";
            this.btnSemantico.Size = new System.Drawing.Size(75, 23);
            this.btnSemantico.TabIndex = 4;
            this.btnSemantico.Text = "Semantico";
            this.btnSemantico.UseVisualStyleBackColor = false;
            this.btnSemantico.Click += new System.EventHandler(this.btnSemantico_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnSalir.Location = new System.Drawing.Point(37, 228);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Location = new System.Drawing.Point(139, 50);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(737, 454);
            this.pnlContenedor.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(888, 516);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSemantico);
            this.Controls.Add(this.btnSintatico);
            this.Controls.Add(this.btnLexico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLexico;
        private System.Windows.Forms.Button btnSintatico;
        private System.Windows.Forms.Button btnSemantico;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}

