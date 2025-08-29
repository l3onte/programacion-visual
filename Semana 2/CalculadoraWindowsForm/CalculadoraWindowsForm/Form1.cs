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
            Display.Text = "";
        }

        private void BtIgual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(Display.Text);

            switch(operacion)
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
                break;
                
                case "Log":
                break;
                
                case "√":
                break;

                case "sin":            
                break;

                case "π":
                break;

                case "cos":
                break;

                case "%":
                break;

                case "!":
                break;

                case "M+":
                break;

                case "M-":
                break;

                case "MC":
                break;

                case "MR":
                break;
            }
        }

        private void BtBa_Click(object sender, EventArgs e)
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
    }
}
