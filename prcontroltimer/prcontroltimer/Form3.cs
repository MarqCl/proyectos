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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            if (is_validate())
            {
                erroricono.Clear();
                MessageBox.Show("Datos agregados correctamente", "validaciones",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
                
                
            }
        private bool is_validate()
        {
            bool no_error = true;

            if(txtnombre.Text==string.Empty)
            {
                erroricono.SetError(txtnombre, "Ingrese su nombre");
                no_error = false;

            }
            else
            {
                try
                {
                    int i = Convert.ToInt32(txtedad.Text);
                }
                catch
                {
                    erroricono.Clear();
                    erroricono.SetError(txtedad, "ingrese Edad");
                    return false;
                }
                try
                {
                    double j = Convert.ToDouble(txtsalario.Text);
                }
                catch
                {
                    erroricono.Clear();
                    erroricono.SetError(txtsalario, "ingrese un salario valido");
                    return false;
                }
            }
            return no_error;
        } 
    }
}
