using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowsForm
{
    public partial class Form1 : Form
    {
        string operacion = "";
        double numero1 = 0;
        double numero2 = 0;
        double memory = 0;

        public void AgregarNumeroAlDisplay(object sender)
        {
            Button boton = (Button)sender;
            Display.Text = (Display.Text == "0") ? boton.Text : Display.Text + boton.Text;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void BtNumero_Click(object sender, EventArgs e)
        {
            AgregarNumeroAlDisplay(sender);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Display.Text.Length == 1)
            {
                Display.Text = "0";
            }
            else
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
            }
        }
        private void btnMplus_Click(object sender, EventArgs e)
        {
            double current = 0;

            if (double.TryParse(Display.Text, out current))
            {
                memory += current;
                Display.Text = memory.ToString();    
            }
            else
            {
                Display.Text = "SYNTAX ERROR";
            }
        }

        private void btnMminimo_Click(object sender, EventArgs e)
        {
            double current = 0;

            if(double.TryParse(Display.Text,out current))
            {
                memory -= current;
                Display.Text = memory.ToString();
            }
            else
            {
                Display.Text = "SYNTAX ERROR";
            }
        }

        private void btnMr_Click(object sender, EventArgs e)
        {
            Display.Text = memory.ToString();
        }

        private void btnMc_Click(object sender, EventArgs e)
        {
            memory = 0;
            Display.Text = "0";
        }

        private void SetOperation(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            numero1 = double.Parse(Display.Text);
            operacion = boton.Text;
            Display.Text = "0";
        }

        private void BtCe_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            Display.Text = "0";
        }

        private void BtIgual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(Display.Text);

            switch (operacion)
            {
                case "+":
                    Display.Text = $"{numero1 + numero2}";
                    break;

                case "-":
                    Display.Text = $"{numero1 - numero2}";
                    break;

                case "x":
                    Display.Text = $"{numero1 * numero2}";
                    break;

                case "/":
                    Display.Text = numero2 != 0 ? (numero1 / numero2).ToString() : "SYNTAX ERROR";
                    break;

                case "^":
                    Display.Text = $"{Math.Pow(numero1, numero2)}";
                    break;

                case "%":
                    Display.Text = numero2 != 0 ? (numero1 % numero2).ToString() : "SYNTAX ERROR";
                    break;

                default:
                    Display.Text = "OPERACIÓN NO VALIDA";
                break;
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = double.Parse(Display.Text);

                if (numero < 0)
                {
                    Display.Text = "SYNTAX ERROR";
                }
                else
                {
                    Display.Text = Math.Sqrt(numero).ToString("0.#####");
                }
            } catch
            {
                Display.Text = "SYNTAX ERROR";
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            Display.Text = Math.PI.ToString();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            if(int.TryParse(Display.Text, out int numero))
            {
                if (numero < 0 || numero > 20)
                {
                    Display.Text = "SYNTAX ERROR";
                    return;
                }

                long factorial = 1;

                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }

                Display.Text = factorial.ToString();
            }
            else
            {
                Display.Text = "SYNTAX ERROR";
            }
        }

        private void btnLogaritmo_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(Display.Text);

            if (numero > 0)
            {
                Display.Text = Math.Log10(numero).ToString();
            }
            else
            {
                Display.Text = "SYNTAX ERROR";
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = double.Parse(Display.Text);
                Display.Text = Math.Sin(numero).ToString();
            }
            catch
            {
                Display.Text = "SYNTAX ERROR";
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = double.Parse(Display.Text);
                Display.Text = Math.Cos(numero).ToString();
            }
            catch
            {
                Display.Text = "SYNTAX ERROR";
            }
        }

        private void BtPunto_Click(object sender, EventArgs e)
        {
            if(!Display.Text.Contains("."))
            {
                Display.Text += ".";
            }
        }
    }
}
