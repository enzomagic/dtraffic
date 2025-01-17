﻿using System;
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
    public partial class Registro : Form
    {
        int codigo = 1;
        public Registro()
        {
            InitializeComponent();
        }
        void limpiar() 
        {
            txtcod.Text = codigo.ToString();
            txtnom.Text = "";
            txtcita.Text = "";
            txttel.Text = "";
            txtfecha.Text = "";
            txthora.Text = "";
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {

            object[] agregardato = 
                    { 
                    codigo.ToString(),
                    txtnom.Text,
                    txtcita.Text, 
                    txttel.Text, 
                    txtfecha.Text,
                    txthora.Text
                    };
                    dataGridView1.Rows.Add(agregardato);
           
            MessageBox.Show("Usuario registrado","Mensaje");
            codigo++;
            txtcod.Text = codigo.ToString();
            limpiar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            txtcod.Text = codigo.ToString();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1760D6");
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int fil = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(fil);
                MessageBox.Show("Usuario eliminado", "Mensaje");
            }
            limpiar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int indice = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows[indice].Cells[0].Value = txtcod.Text;
                dataGridView1.Rows[indice].Cells[1].Value = txtnom.Text;
                dataGridView1.Rows[indice].Cells[2].Value = txtcita.Text;
                dataGridView1.Rows[indice].Cells[3].Value = txttel.Text;
                dataGridView1.Rows[indice].Cells[4].Value = txtfecha.Text;
                dataGridView1.Rows[indice].Cells[5].Value = txthora.Text;
                MessageBox.Show("Usuario modificado ", "Mensaje");
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int fila = dataGridView1.CurrentCell.RowIndex;
                txtcod.Text = dataGridView1[0, fila].Value.ToString();
                txtnom.Text = dataGridView1[1, fila].Value.ToString();
                txtcita.Text = dataGridView1[2, fila].Value.ToString();
                txttel.Text = dataGridView1[3, fila].Value.ToString();
                txtfecha.Text = dataGridView1[4, fila].Value.ToString();
                txthora.Text = dataGridView1[5, fila].Value.ToString();
                txtcalend.Text = dataGridView1[6, fila].Value.ToString();
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txthora_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
