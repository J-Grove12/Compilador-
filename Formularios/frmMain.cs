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
            this.Hide();
            frmLexico frmLexico = new frmLexico();
            frmLexico.Show();
         

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
    }
}
