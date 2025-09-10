using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prcontroltimer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btingresar_Click(object sender, EventArgs e)
        {
            //declaracion de var
            string nombre;
            //entrada de datos
            nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre:", "registro de datos", "Juan Carlos", 300, 300);
            MessageBox.Show("Bienvenido usuario: " + nombre, "Sistema Administrativo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("realmente desea salir de la aplicación?", "salir del programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(opcion==DialogResult.OK)
            {
                Close();
            }
        }
    }
}
