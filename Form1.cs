using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversores_no_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, resultado;





            peso = double.Parse(txtQuilos.Text);

            resultado = peso * 2.205;





            txtResultado.Text = "O Seu peso em Libras é de: " + resultado;

            








        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtQuilos.Clear();
            txtResultado.Clear();
        }

        private void btnCalcularLibra_Click(object sender, EventArgs e)
        {
            double libra, resultado;





            libra = double.Parse(txtLibras.Text); 

            resultado = libra / 2.205;





        txtLibraResultado.Text = "O Seu peso em Quilos é de: " + resultado; 

        }

        private void btnLimparLibra_Click(object sender, EventArgs e)
        {
            txtLibras.Clear();
            txtLibraResultado.Clear(); 
        }
    }
    }

