using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class FormAgenda : Form
    {
        public FormAgenda()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar = (Button)sender;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void txbNome_Enter(object sender, EventArgs e)
        {
            if (txbNome.Text == "NOME")
            {
                txbNome.Text = "";
                txbNome.ForeColor = Color.LightGray;
            }
        }
        private void txbNumero_TextChanged(object sender, EventArgs e)
        {
        }
        private void txbNome_Leave(object sender, EventArgs e)
        {
            if (txbNome.Text == "")
            {
                txbNome.Text = "NOME";
                txbNome.ForeColor = Color.DimGray;
            }
        }
        private void txbNumero_Enter(object sender, EventArgs e)
        {
            if (txbNumero.Text == "NUMERO")
            {
                txbNumero.Text = "";
                txbNumero.ForeColor = Color.LightGray;
            }
        }
        private void txbNumero_Leave(object sender, EventArgs e)
        {
            if (txbNumero.Text == "")
            {
                txbNumero.Text = "NUMERO";
                txbNumero.ForeColor = Color.DimGray;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
