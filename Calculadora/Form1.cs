using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador = string.Empty;
        string Numero = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private void butnumero0_Click(object sender, EventArgs e)
        {
            Numero = Numero + "0";
        }

        private void Pantallapri_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void butnumero1_Click(object sender, EventArgs e)
        {
            Numero = Numero + "1";
        }

        private void butnumero2_Click(object sender, EventArgs e)
        {
            Numero = Numero + "2";
        }

        private void butnumero3_Click(object sender, EventArgs e)
        {
            Numero = Numero + "3";
        }

        private void butnumero4_Click(object sender, EventArgs e)
        {
            Numero = Numero + "4";
        }

        private void butnumero5_Click(object sender, EventArgs e)
        {
            Numero = Numero + "5";
        }

        private void butnumero6_Click(object sender, EventArgs e)
        {
            Numero = Numero + "6";
        }

        private void butnumero7_Click(object sender, EventArgs e)
        {
            Numero = Numero + "7";
        }

        private void butnumero8_Click(object sender, EventArgs e)
        {
            Numero = Numero + "8";
        }

        private void butnumero9_Click(object sender, EventArgs e)
        {
            Numero = Numero + "9";
        }

        private void butsuma_Click(object sender, EventArgs e)
        {
            Numero = Numero + "+";

            string[] num = Numero.Split('+');
            int sumar = 0;
            for (int a=0;a<num.Length;a++)
            {
                if(num[a] !="")
                sumar = sumar + Convert.ToInt32(num[a]);
            }
            Pantallapri.Text = Numero;
            Pantallaant.Text = sumar.ToString();
        }

        private void butresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Pantallapri.Text);
            Pantallapri.Clear();
        }

        private void butmultiplicar_Click(object sender, EventArgs e)
        {
            operador = "x";
            primero = double.Parse(Pantallapri.Text);
            Pantallapri.Clear();
        }

        private void butdividir_Click(object sender, EventArgs e)
        {
            operador = "÷";
            primero = double.Parse(Pantallapri.Text);
            Pantallapri.Clear();
        }

        private void butcoma_Click(object sender, EventArgs e)
        {
            Pantallapri.Text = Pantallapri.Text + ",";
            butcoma.Enabled = false;
        }

        private void butigual_Click(object sender, EventArgs e)
        {
            
        }
    }
}
