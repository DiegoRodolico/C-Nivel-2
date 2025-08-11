using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Windows2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //edad solo numeros
        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
        //cerrar con cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //apellido
        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string apellido = txt_apellido.Text;
            if (txt_apellido.Text != "")
            {
                string apellido = txt_apellido.Text;
            }
            //else
            //{
            //    txt_apellido.BackColor = Color.Red;
            //}
        }
        //nombre
        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "")
            {
                string nombre = txt_nombre.Text;
            }
            //else
            //{
            //    txt_nombre.BackColor = Color.Red;
            //}
        }
        //edad
        private void txt_edad_TextChanged(object sender, EventArgs e)
        {
            if (txt_edad.Text != "")
            {
                string edad = txt_edad.Text; 
            }
            //else
            //{
            //    txt_edad.BackColor = Color.Red;
            //}
        }
        //direccion
        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {
            if(txt_direccion.Text != "")
            {
            string direccion = txt_direccion.Text;
            }
            //else
            //{
            //    txt_direccion.BackColor = Color.Red;
            //}
        }
        private void txt_resultado_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_apellido.Text != "" && txt_direccion.Text != "" && txt_edad.Text != "" && txt_nombre.Text != "")
            {
                txt_resultado.Text = "Apellido y Nombre : " + txt_apellido.Text + " " + txt_nombre.Text + Environment.NewLine + "Edad : " + txt_edad.Text + Environment.NewLine + "Direccion : " + txt_direccion.Text;
            }
            //else
            //{
            //    //txt_direccion.BackColor = Color.Red txt_edad.BackColor = Color.Red; || txt_nombre.BackColor = Color.Red || 
            //}
            if (txt_apellido.Text == "")
                txt_apellido.BackColor = Color.Red;
            else
                txt_apellido.BackColor = SystemColors.Window;

            if (txt_nombre.Text == "")
                txt_nombre.BackColor = Color.Red;
            else
                txt_nombre.BackColor = SystemColors.Window;

            if (txt_edad.Text == "")
                txt_edad.BackColor = Color.Red;
            else
                txt_edad.BackColor = SystemColors.Window;

            if (txt_direccion.Text == "")
                txt_direccion.BackColor = Color.Red;
            else
                txt_direccion.BackColor = SystemColors.Window;
            //lo hizo chatgpt este ultimo...

        }   
    }
}




