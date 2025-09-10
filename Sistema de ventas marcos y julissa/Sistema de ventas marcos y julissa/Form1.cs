using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas_marcos_y_julissa
{
    public partial class Form1 : Form
    {
        //declaramos variables que contienen nobre y contraseña correctos
        string nombre1 = "marcos";
        string nombre2 = "julissa";
        string password1 = "libro123";
        string password2 = "libro1234";

        public Form1()
        {
            
            InitializeComponent();
            //iniciaizo el labelpassword como invisible
            labelpassword.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //obtenemos el texto de los textbox
            string nombreIngresado = txtname.Text;
            string passwordIngresado = txtpassword.Text;
            //comprobamos que los campos están vacios
            if (nombreIngresado == "" || passwordIngresado == "")
            {
                //mostramos un mensaje de error
                MessageBox.Show("Debes ingresar datos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //comprobamos si el nobre y la contraseña son correctas
                if((nombreIngresado==nombre1 && passwordIngresado== password1) || (nombreIngresado==nombre2 && passwordIngresado==password2))
                {
                    //mostramos un mensaje de exito
                    MessageBox.Show("se inició sesión correctaente", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //ocultamos el labelpassword
                    labelpassword.Visible = passwordIngresado != ""; /* Lo que hace es asignar un valor
                                  booleano (verdadero o falso) a la propiedad Visible 
                                  del labelpassword, que determina si se muestra
                                  o no en el formulario. El valor booleano depende
                                  de la comparación que se hace entre el 
                                  passwordIngresado y una cadena vacía (“”), 
                                  usando el operador de desigualdad (!=), que devuelve
                                  verdadero si los valores son distintos y falso si son
                                  iguales. Es decir, si el passwordIngresado es diferente
                                  de una cadena vacía, el labelpassword se mostrará, y si
                                  es igual, se ocultará.*/
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("estás seguro de cerrar el programa?", "ventana de salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        

    }
}
