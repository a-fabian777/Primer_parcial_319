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
        int pantalla;
        double a;
        double b;
        double res;
        string op;

        public Form1()
        {
            InitializeComponent();
            pantalla = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pantalla = pantalla * 10 + Convert.ToInt32(((Button)sender).Text);
            Pantalla.Text = pantalla.ToString();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            op = "+";
            pantalla = 0;
            a = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            op = "-";
            pantalla = 0;
            a = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            op = "*";
            pantalla = 0;
            a = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            op = "/";
            pantalla = 0;
            a = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            b = double.Parse(Pantalla.Text);
            switch (op)
            {
                case "+":
                    res = a + b;
                    Pantalla.Text = res.ToString();
                    pantalla = 0;
                    break;
                case "-":
                    res = a - b;
                    Pantalla.Text = res.ToString();
                    pantalla = 0;
                    break;
                case "*":
                    res = a * b;
                    Pantalla.Text = res.ToString();
                    pantalla = 0;
                    break;
                case "/":
                    res = a / b;
                    Pantalla.Text = res.ToString();
                    pantalla = 0;
                    break;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            pantalla = 0;
            Pantalla.Clear();
        }
    }
}
