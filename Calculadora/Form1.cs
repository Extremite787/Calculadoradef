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

        Classuma for1 = new Classuma();
        Clasresta for2 = new Clasresta();
        Clasmultiplicacion for3 = new Clasmultiplicacion();
        Clasdivicion for4 = new Clasdivicion();
        private void butnumero0_Click(object sender, EventArgs e)
        {
            Pantallapri.Text = Pantallapri.Text+"0";
        }

        private void Pantallapri_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void butnumero1_Click(object sender, EventArgs e)
        {
            Pantallapri.Text = Pantallapri.Text + "1";
        }

        private void butnumero2_Click(object sender, EventArgs e)
        {
            Pantallapri.Text = Pantallapri.Text + "2";
        }

        private void butnumero3_Click(object sender, EventArgs e)
        {
            Pantallapri.Text = Pantallapri.Text + "3";
        }

        private void butnumero4_Click(object sender, EventArgs e)
        {
            Pantallapri.Text = Pantallapri.Text + "4";
        }

        private void butnumero5_Click(object sender, EventArgs e)
        {
            Pantallapri.Text = Pantallapri.Text + "5";
        }

        private void butnumero6_Click(object sender, EventArgs e)
        {
            Pantallapri.Text = Pantallapri.Text + "6";
        }

        private void butnumero7_Click(object sender, EventArgs e)
        {
            Pantallapri.Text = Pantallapri.Text + "7";
        }

        private void butnumero8_Click(object sender, EventArgs e)
        {
            Pantallapri.Text = Pantallapri.Text + "8";
        }

        private void butnumero9_Click(object sender, EventArgs e)
        {
            Pantallapri.Text = Pantallapri.Text + "9";
        }

        private void butsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Pantallapri.Text);
            Pantallaant.Text = Pantallapri.Text + "+";
            Pantallapri.Clear();
        }

        private void butresta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Pantallapri.Text);
            Pantallaant.Text = Pantallapri.Text + "-";
            Pantallapri.Clear();
        }

        private void butmultiplicar_Click(object sender, EventArgs e)
        {
            operador = "x";
            primero = double.Parse(Pantallapri.Text);
            Pantallaant.Text = Pantallapri.Text + "x";
            Pantallapri.Clear();
        }

        private void butdividir_Click(object sender, EventArgs e)
        {
            operador = "÷";
            primero = double.Parse(Pantallapri.Text);
            Pantallaant.Text = Pantallapri.Text + "÷";
            Pantallapri.Clear();
        }

        private void butcoma_Click(object sender, EventArgs e)
        {
            Pantallapri.Text = Pantallapri.Text + ",";
            butcoma.Enabled = false;
        }

        private void butigual_Click(object sender, EventArgs e)
        {

                segundo = double.Parse(Pantallapri.Text);
                double Sum, Res, Mul, Div;

                switch (operador)
                {
                    case "+":
                        Sum = for1.Suma((primero), (segundo));
                        Pantallapri.Text = Sum.ToString();
                        Pantallaant.Clear();
                        break;
                    case "-":
                        Res = for2.Restar((primero), (segundo));
                        Pantallapri.Text = Res.ToString();
                        Pantallaant.Clear();
                        break;
                    case "x":
                        Mul = for3.Multiplicar((primero), (segundo));
                        Pantallapri.Text = Mul.ToString();
                        Pantallaant.Clear();
                        break;
                    case "÷":
                        Div = for4.Divicion((primero), (segundo));
                        Pantallapri.Text = Div.ToString();
                        Pantallaant.Clear();
                        break;
                }
            
        }

        private void butC_Click(object sender, EventArgs e)
        {
            Pantallapri.Clear();
            Pantallaant.Clear();
        }

        private void butCE_Click(object sender, EventArgs e)
        {
            Pantallapri.Text = "";
            Pantallapri.Clear();
        }

        private void butborrar_Click(object sender, EventArgs e)
        {
            if (Pantallapri.TextLength == 1)
            {
                Pantallapri.Text = Pantallapri.Text.Remove(Pantallapri.Text.Length - 1, 1);
                
            }
            if (Pantallapri.Text.Length == 1)
            {
                Pantallapri.Text = "0";
                
            }
        }
    }
}
