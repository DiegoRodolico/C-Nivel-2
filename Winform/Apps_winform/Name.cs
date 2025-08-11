using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apps_winform
{
    public partial class txt_algo2: Form
    {
        public txt_algo2()
        {
            InitializeComponent();
        }

        private void Name_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Que Hace Loco");
        }

        private void Name_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Goku Chau...");
        }

        private void btn_algo_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Haciendo Click");
            //this.BackColor = Color.Beige;
            if (txt_algo.Text == (""))
            {
                txt_algo.BackColor = Color.DarkRed;

            } 
            else
            {
                txt_algo.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void btn_algo_Click(object sender, EventArgs e)
        {
            //MouseEventArgs click = (MouseEventArgs) e ;
            //if (click.Button == MouseButtons.Left) 
            //{
            //    MessageBox.Show("Boton Izquierdo");
            //}
            //else if (click.Button == MouseButtons.Right)
            //{
            //    MessageBox.Show("Boton derecho");
            //}
            //else if (click.Button == MouseButtons.Middle)
            //{
            //    MessageBox.Show("Boton del diome");
            //}
        }

        private void Name_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
            {
                MessageBox.Show("Boton Izquierdo");
            }
            else if (click.Button == MouseButtons.Right)
            {
                MessageBox.Show("Boton derecho");
            }
            else if (click.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Boton del diome");
            }
        }

        private void lbl_algo_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_algo.BackColor = Color.Cyan;
            lbl_algo.Cursor = Cursors.Hand;
        }

        private void lbl_algo_MouseLeave(object sender, EventArgs e)
        {
            lbl_algo.BackColor = System.Drawing.SystemColors.Control;
            lbl_algo.Cursor = Cursors.Cross;
        }

        private void txt_algo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txt_algo_2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txt_algo_2.Text.Length + " Caracteres");
        }
    }
}
