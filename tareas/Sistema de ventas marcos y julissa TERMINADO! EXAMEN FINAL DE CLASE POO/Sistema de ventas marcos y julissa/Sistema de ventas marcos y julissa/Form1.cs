/*explicacion :)
 * 
 * primero que todo este programa se hizo en visual studio 2013 con C#, y que:
 los creadores de este programa son solo marcos cano y julissa mercado, dos programadores facheros...

 * 
 * El programa es una aplicación de ventas que consta de dos formularios principales:
 * `Form1` y `Form2`. y marcos cano programó mayor parte en form1 para que se uniera form2
 * y se programó tambien en form2 la union. ambos julissa y marcos en equipo trabajaron el
 * codigo. gracias.

1. Form1 por marcos cano (Inicio de Sesión):
   - En `Form1`, el usuario debe ingresar un nombre de usuario y una contraseña 
 * y hacer clic en un botón para iniciar sesión.
   - Se valida si las credenciales ingresadas son correctas. En este caso, el 
 * nombre de usuario es "juano caballo" y la contraseña es "libro123", pero esto 
 * puede variar según tus necesidades.
   - Si las credenciales son correctas, se muestra un mensaje de bienvenida y se oculta `Form1`.
   - A continuación, se abre `Form2` (el formulario principal de ventas) y se suscribe a
 * un evento llamado `FacturaGeneradaExitosamente`.

2. **Form2 por julissa y logica y de algunos arreglos marcos(Venta de Productos):**
   - En `Form2`, el usuario puede seleccionar productos de una lista, ingresar la cantidad
 * y agregarlos a una factura.
   - Se realiza un seguimiento de los productos y sus totales en una tabla (en este caso, 
 * un `DataGridView`).
   - Cuando el usuario completa la venta y hace clic en el botón "Vender", se genera una
 * factura que muestra la información de la venta, como el nombre de la empresa, la fecha,
 * el total, etc.
   - La factura también se imprime en una impresora virtual (en este caso, "Microsoft XPS
 * Document Writer").
   - Luego, se muestra un mensaje agradeciendo al usuario por su compra y se marca que 
 * la factura se ha generado con éxito.
   - Finalmente, `Form2` se cierra.

3. **Evento `FacturaGeneradaExitosamente`:**
   - Este evento se utiliza para notificar a `Form1` que la factura se ha generado con éxito
 * en `Form2`.
   - Cuando se dispara este evento en `Form2`, `Form1` captura el evento y cierra su propia
 * ventana (esto ocurre solo si la factura se generó correctamente).

En resumen, `Form1` maneja la autenticación del usuario y la apertura de `Form2`
 * (el formulario principal de ventas). `Form2` permite al usuario realizar ventas, 
 * generar facturas y notifica a `Form1` a través de un evento si la factura se generó
 * con éxito. Esto permite que `Form1` se cierre solo si la venta se realizó correctamente
 * en `Form2`.

Este diseño divide las responsabilidades de autenticación y ventas en dos formularios
 * separados para una mejor organización y modularidad del código. 
 * 
 * gracias por su atencion conchetumadre ok no XD. Gracias caballero o dama que lee esto.
 * 
*/


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
        public event EventHandler FacturaGeneradaExitosamente;
        public Form1()
        {
            InitializeComponent();
            labelpassword.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreIngresado = txtname.Text.Trim();
            string passwordIngresado = txtpassword.Text;

            if (nombreIngresado == "" || passwordIngresado == "")
            {
                MessageBox.Show("Debes ingresar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelpassword.Visible = true;
            }
            else if (ValidarUsuarioYContraseña(nombreIngresado, passwordIngresado))
            {
                MessageBox.Show("¡Bienvenido, " + nombreIngresado + "! Se inició sesión correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                labelpassword.Visible = false;

                // Aquí puedes abrir Form2 si las credenciales son correctas
                Form2 form2 = new Form2();

                form2.FacturaGeneradaExitosamente += (sender2, args) =>
                {
                    // Cerrar Form1 solo si la factura se generó con éxito
                    this.Close();
                };

                form2.Show();
                this.Hide(); // Oculta Form1

            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelpassword.Visible = true;
            }

            
        }

        private bool ValidarUsuarioYContraseña(string usuario, string contraseña)
        {
            // Aquí debes implementar la lógica real de validación de usuario y contraseña.
            // Por ejemplo, puedes comparar con una base de datos o un conjunto de usuarios válidos.

            // En este ejemplo, se valida contra una combinación fija.
            return usuario == "juano caballo" && contraseña == "libro123";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estás seguro de cerrar el programa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // No hacemos visible el labelpassword al inicio
        }
    }
}

