using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindows2_TP_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_edad_TextChanged(object sender, EventArgs e)
        {
            //if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            //   e.Handled = true;
            


        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string texto1 = txt_apellido.Text;
            string texto2 = txt_nombre.Text;
            string texto3 = txt_edad.Text;
            string texto4 = txt_direccion.Text;
            txt_resultado.Text = texto1 + Environment.NewLine + texto2 + Environment.NewLine + texto3 + Environment.NewLine + texto4;


        }
        private void ltv_resultado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
              e.Handled = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}






