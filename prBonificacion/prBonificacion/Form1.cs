using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prBonificacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int horasextras, horasnormales;
            double pagohnormal, pagohextra;
            byte nhijos;
            double sueldobruto, sueldoneto, bonificacion;
            Boolean marcado;
            //entrada de datos
            horasnormales = Convert.ToInt32(txthorasnormales.Text);
            horasextras = Convert.ToInt32(txthorasextras.Text);
            pagohnormal = Convert.ToDouble(txtpagohnormal.Text);
            pagohextra = Convert.ToDouble(txtpagohextras.Text);
            nhijos = Convert.ToByte(nphijos.Value);
            marcado = Convert.ToBoolean(chkbonificacion.Checked);
            //Inicializar
            bonificacion = 0.0;
            //proceso
            sueldobruto = (horasnormales * pagohnormal) + (horasextras * pagohextra);
            //evaluamos si recibirá la bonificación respectiva
            if (marcado==true)
            {
                bonificacion = nhijos * 20;
            }
            sueldoneto = sueldobruto + bonificacion;

            //Salida de inforación
            txtsueldobruto.Text = "$. " + Convert.ToString(sueldobruto);
            txtbonificacion.Text = "$. " + Convert.ToString(bonificacion);
            txtsueldoneto.Text = "$. " + Convert.ToString(sueldoneto);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txthorasextras.Clear();
            txthorasnormales.Clear();
            txtpagohextras.Clear();
            txtsueldobruto.Clear();
            txtsueldoneto.Clear();
            txtbonificacion.Clear();
            nphijos.Value = 0;
            chkbonificacion.Checked = false;
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
