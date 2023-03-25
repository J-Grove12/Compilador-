
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Compilador.Clases;



namespace Compilador.Formularios
{
    public partial class frmLexico : Form
    {
        public frmLexico()
        {
            InitializeComponent();
        }
         public String Diccionario(String aComparar)
        {
            String token = "";
            switch (aComparar)
            {
                case "package":
                    token = "3";
                    break;
                case "public":
                    token = "4";
                    break;
                case "class":
                    token = "5";
                    break;
                case "private":
                    token = "6";
                    break;
                case "double":
                    token = "7";
                    break;
                case "this":
                    token = "8";
                    break;
                case "void":
                    token = "9";
                    break;
                case "return":
                    token = "10";
                    break;
                case "*":
                    token = "11";
                    break;
                case "=":
                    token = "12";
                    break;
                case ";":
                    token = "13";
                    break;
                case "(":
                    token = "14";
                    break;
                case ")":
                    token = "15";
                    break;
                case "{":
                    token = "16";
                    break;
                case "}":
                    token = "17";
                    break;
                case ",":
                    token = "18";
                    break;
                case ".":
                    token = "19";
                    break;
            }
            return token;
        }
        void Metodo()
        {
            String Codigo = rtxtCode.Text;
            char[] salto = { '\n' };
            char[] espacio = { ' ' };

            String[] ArrayRenglone =Codigo.Split(salto);

            for (int i = 0; i < ArrayRenglone.Length; i++)
            {
                String[] ArrayPalabra= ArrayRenglone[i].Split(espacio);
                for (int j = 0; j < ArrayPalabra.Length; j++)
                {
                    if (ArrayPalabra[j] != "")
                    {
                        ArrayPalabra[j] = ArrayPalabra[j].Replace("\n", "");
                        DataGridViewRow tabla = (DataGridViewRow)dtgToken.Rows[0].Clone();
                        tabla.Cells[0].Value = ArrayPalabra[j];
                        tabla.Cells[1].Value = Diccionario(ArrayPalabra[j]);
                        dtgToken.Rows.Add(tabla);
                    }
                  

                }
            }
          
        }
   
       
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            Metodo();
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtCode.Clear();
            rtxtCode.Focus();
            dtgToken.Rows.Clear();
        }

        private void btnsolucion_Click(object sender, EventArgs e)
        {
            int con = dtgToken.Rows.Count;
            int[] vec = new int[con];
            string cadena = "";
            for (int i = 0; i < con; i++)
            {
                vec[i] = Convert.ToInt32(dtgToken.Rows[i].Cells[1].Value);
               cadena += "[ "+vec[i].ToString()+" ]";
            }
            rtbSolucion.Text = cadena;
        }

    }
}
