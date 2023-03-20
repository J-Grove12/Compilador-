namespace Compilador.Formularios
{
    partial class frmLexico
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.rtxtCode = new System.Windows.Forms.RichTextBox();
            this.rtbSolucion = new System.Windows.Forms.RichTextBox();
            this.btnsolucion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtTitle.Location = new System.Drawing.Point(37, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(221, 24);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "ANALIZADOR LEXICO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.vlrToken});
            this.dataGridView1.Location = new System.Drawing.Point(529, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(225, 408);
            this.dataGridView1.TabIndex = 1;
            // 
            // Token
            // 
            this.Token.HeaderText = "TOKEN";
            this.Token.Name = "Token";
            // 
            // vlrToken
            // 
            this.vlrToken.HeaderText = "VALOR";
            this.vlrToken.Name = "vlrToken";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(143, 292);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 28);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(245, 292);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(91, 28);
            this.btnAnalyze.TabIndex = 3;
            this.btnAnalyze.Text = "Analizar";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // rtxtCode
            // 
            this.rtxtCode.Location = new System.Drawing.Point(41, 47);
            this.rtxtCode.Name = "rtxtCode";
            this.rtxtCode.Size = new System.Drawing.Size(436, 239);
            this.rtxtCode.TabIndex = 4;
            this.rtxtCode.Text = "";
            // 
            // rtbSolucion
            // 
            this.rtbSolucion.Location = new System.Drawing.Point(25, 371);
            this.rtbSolucion.Name = "rtbSolucion";
            this.rtbSolucion.Size = new System.Drawing.Size(498, 96);
            this.rtbSolucion.TabIndex = 5;
            this.rtbSolucion.Text = "";
            // 
            // btnsolucion
            // 
            this.btnsolucion.Location = new System.Drawing.Point(343, 293);
            this.btnsolucion.Name = "btnsolucion";
            this.btnsolucion.Size = new System.Drawing.Size(124, 23);
            this.btnsolucion.TabIndex = 6;
            this.btnsolucion.Text = "Crear Solución";
            this.btnsolucion.UseVisualStyleBackColor = true;
            // 
            // frmLexico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(842, 524);
            this.Controls.Add(this.btnsolucion);
            this.Controls.Add(this.rtbSolucion);
            this.Controls.Add(this.rtxtCode);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTitle);
            this.Name = "frmLexico";
            this.Text = "frmLexico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrToken;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.RichTextBox rtxtCode;
        private System.Windows.Forms.RichTextBox rtbSolucion;
        private System.Windows.Forms.Button btnsolucion;
    }
}