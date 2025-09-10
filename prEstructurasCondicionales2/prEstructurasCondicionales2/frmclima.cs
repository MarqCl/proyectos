using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prEstructurasCondicionales2
{
    public partial class frmclima : Form
    {
        public frmclima()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de var
            byte temperatura;
            string clima;
            //entrada de datos
            temperatura = Convert.ToByte(txttemperatura.Text);
            //proceso
            if(temperatura<10)
            {
                clima = "frio";
            }
            else if (temperatura >= 10 && temperatura <= 20) 
            {
                clima = "nublado";
            } else if(temperatura>20 && temperatura<=30)
            {
                clima = "calor";
            }
            else
            {
                clima = "tropical";
            }
            //salida de informaccion
            txtclima.Text = clima;


        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtclima.Clear();
            txttemperatura.Clear();

        }
    }
}
