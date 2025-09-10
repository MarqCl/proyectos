using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prOperadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btcalcular_Click(object sender, EventArgs e)
        {
            //declaracion de variable
            double num1, num2;
            double suma;
            double resta, mult, div, potencia, raiz;
           //entrada de datos
            num1 = double.Parse(txtnumero1.Text);
            num2 = Convert.ToDouble(txtnumero2.Text);
            //proceso
            suma = num1 + num2;
            resta = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;
            potencia = Math.Pow(num1, num2);
            raiz = Math.Pow(num1, (1 / num2));
            //salida de la info
            txtsuma.Text = Convert.ToString(suma);
            txtresta.Text = Convert.ToString(resta);
            txtmultiplicacion.Text = Convert.ToString(mult);
            txtpotencia.Text = Convert.ToString(potencia);
            txtdivision.Text = Convert.ToString(div);
            txtraiz.Text = Convert.ToString(raiz);
        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtsuma.Clear();
            txtresta.Clear();
            txtmultiplicacion.Clear();
            txtdivision.Clear();
            txtpotencia();
            txtraiz.Clear();

        }
    }
}
