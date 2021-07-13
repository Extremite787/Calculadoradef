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

        public Form1()
        {
            InitializeComponent();
        }

        Clasporcentaje per = new Clasporcentaje();
        Classuma for1 = new Classuma();
        Clasresta for2 = new Clasresta();
        Clasmultiplicacion for3 = new Clasmultiplicacion();
        Clasdivicion for4 = new Clasdivicion();
        private void butnumero0_Click(object sender, EventArgs e)
        {
            Pantallapri.Text = Pantallapri.Text + "0";
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
            
            try
            {
                operador = "+";
                primero = double.Parse(Pantallapri.Text);
                Pantallaant.Text = Pantallapri.Text + "+";
                Pantallapri.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void butresta_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "-";
                primero = double.Parse(Pantallapri.Text);
                Pantallaant.Text = Pantallapri.Text + "-";
                Pantallapri.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void butmultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "x";
                primero = double.Parse(Pantallapri.Text);
                Pantallaant.Text = Pantallapri.Text + "x";
                Pantallapri.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void butdividir_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "÷";
                primero = double.Parse(Pantallapri.Text);
                Pantallaant.Text = Pantallapri.Text + "÷";
                Pantallapri.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void butcoma_Click(object sender, EventArgs e)
        {
            if (Pantallapri.Text.Contains(","))
            {
                return;
            }
            Pantallapri.Text += ",";
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
                    Pantallaant.Text = Pantallaant.Text + segundo + "=";
                    break;
                case "-":
                    Res = for2.Restar((primero), (segundo));
                    Pantallapri.Text = Res.ToString();
                    Pantallaant.Text = Pantallaant.Text + segundo + "=";
                    break;
                case "x":
                    Mul = for3.Multiplicar((primero), (segundo));
                    Pantallapri.Text = Mul.ToString();
                    Pantallaant.Text = Pantallaant.Text + segundo + "=";
                    break;
                case "÷":
                    Div = for4.Divicion((primero), (segundo));
                    Pantallapri.Text = Div.ToString();
                    Pantallaant.Text = Pantallaant.Text + segundo + "=";
                    break;
            }
        }

        private void butC_Click(object sender, EventArgs e)
        {
            try
            {
                Pantallapri.Clear();
                Pantallaant.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void butCE_Click(object sender, EventArgs e)
        {
            try
            {
                Pantallapri.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void butborrar_Click(object sender, EventArgs e)
        {
            if (Pantallapri.Text.Length > 0)
            {
                Pantallapri.Text = Pantallapri.Text.Remove(Pantallapri.Text.Length - 1);
            }
        }

        private void butnegativo_Click(object sender, EventArgs e)
        {
            primero = Convert.ToInt32(Pantallapri.Text);
            primero *= -1;
            Pantallapri.Text = primero.ToString();
        }

        private void butcuadrado_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "²";
                primero = Convert.ToInt32(Pantallapri.Text);
                Pantallaant.Text = Pantallapri.Text + "²" + "=";
                primero = primero * primero;
                Pantallapri.Text = primero.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void butdividido1_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "1/";
                primero = Convert.ToInt32(Pantallapri.Text);
                Pantallaant.Text = "1/" + Pantallapri.Text + "=";
                primero = 1 / primero;
                Pantallapri.Text = primero.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void butraizcuadrado_Click(object sender, EventArgs e)
        {
            try
            {
                operador = "²√";
                primero = Convert.ToInt32(Pantallapri.Text);
                Pantallaant.Text = "²√" + Pantallapri.Text;
                double Resultado, num = primero;
                Resultado = Math.Sqrt(num);
                Pantallapri.Text = Resultado.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void butporciento_Click(object sender, EventArgs e)
        {
            double Por;
            Por = per.Porcentaje((primero), (segundo));
            Pantallapri.Text = Por.ToString();
            Pantallaant.Text = Pantallaant.Text + "%";
        }
    }
}
