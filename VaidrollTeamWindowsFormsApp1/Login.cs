using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaidrollTeamWindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (txrut.Text == "12345k" || txpass.Text == "1234"){
                MessageBox.Show("Sesion iniciada");
                txrut.Clear();
                txpass.Clear();
                Interfaz Form = new Interfaz();
                Form.ShowDialog();
            }

            else
            {
                MessageBox.Show("Error autenticación");
                txpass.Clear();
                txrut.Clear();
                txrut.Focus();
                return;
            }

        }

        private void txpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txrut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
