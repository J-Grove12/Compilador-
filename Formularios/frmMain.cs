using Compilador.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLexico_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new frmLexico());

        }

        private void btnSintatico_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSintatico frmSintatico = new frmSintatico();
            frmSintatico.Show();
        }

        private void btnSemantico_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSemeantico frmSemantico = new frmSemeantico();
            frmSemantico.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //variable que guarda el formulario activo
        private Form FormularioActivo = null;
        //abrir formularios hijos
        private void abrirFormulariosHijos(Form formularioHijo)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
    }
}

