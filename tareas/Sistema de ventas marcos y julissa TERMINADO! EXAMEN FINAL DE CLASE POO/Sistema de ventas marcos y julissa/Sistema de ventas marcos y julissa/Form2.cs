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
    public partial class Form2 : Form
    {
        public bool FacturaGenerada { get; set; }
        public Form2()
        {
            InitializeComponent();
            FacturaGenerada = false;
        }

        public event EventHandler FacturaGeneradaExitosamente;

        



        private void cmbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigo;
            string nom;

            codigo = cmbproducto.SelectedIndex;
            nom = cmbproducto.SelectedItem.ToString();

            switch (codigo)
            {
                case 0: lblcodigo.Text = "0011";
                    break;
                case 1: lblcodigo.Text = "0022";
                    break;
                default: lblcodigo.Text = "0033";
                    break;
            }

            switch (nom)
            {
                case "Libro": lblname.Text = "Libro";
                    break;
                case "Cuaderno": lblname.Text = "Cuaderno";
                    break;
                default: lblname.Text = "Cuaderno"; break;
            }

            float precio;

            if (codigo >= 0 && codigo < 1)
            {
                precio = 150;
            }
            else if (codigo >= 1 && codigo < 2)
            {
                precio = 120;
            }
            else
            {
                precio = 140;
            }

            lblprecio.Text = precio.ToString();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvlista);

            fila.Cells[0].Value = lblcodigo.Text;
            fila.Cells[1].Value = lblname.Text;

            float precio;
            if (float.TryParse(lblprecio.Text, out precio))
            {
                // La conversión fue exitosa, el contenido de lblprecio.Text es un número válido.
                // Ahora puedes continuar con el resto del código.
                fila.Cells[2].Value = precio.ToString();
                float cantidad;
                if (float.TryParse(txtcantidad.Text, out cantidad))
                {
                    fila.Cells[3].Value = txtcantidad.Text;
                    fila.Cells[4].Value = (precio * cantidad).ToString();
                    dgvlista.Rows.Add(fila);
                    lblcodigo.Text = lblname.Text = lblprecio.Text = txtcantidad.Text = "";
                    obtenerTotal();
                }
                else
                {
                    MessageBox.Show("La cantidad no es válida.");
                }
            }
            else
            {
                MessageBox.Show("El precio no es válido.");
            }
            
        }


        

    

        

        public void obtenerTotal()//para que vaya auentando cada vez que yo co
        {
            float costotal = 0;
            int contador = 0;
            contador = dgvlista.RowCount;

            for(int i=0;i<contador;i++)
            {
                costotal += float.Parse(dgvlista.Rows[i].Cells[4].Value.ToString());
            }

            lbltotal.Text = costotal.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Desea eliminar producto?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rppta == DialogResult.Yes)
                {
                    dgvlista.Rows.Remove(dgvlista.CurrentRow);
                }
            }
            catch
            {

            }
            obtenerTotal();
        }             

        private void txtefectivo_TextChanged(object sender, EventArgs e)//cambio o vuelto
        {
            try
            {
                lbldevolucion.Text = (float.Parse(txtefectivo.Text) - float.Parse(lbltotal.Text)).ToString();

            }
            catch { }
        }

        private void btnvender_Click(object sender, EventArgs e)
        {
            clsfactura.CreaTicket Ticket1 = new clsfactura.CreaTicket();

            Ticket1.TextoCentro("Empresa Libros y más"); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac: 02030440");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: xxxx");
            Ticket1.TextoIzquierda("");
            clsfactura.CreaTicket.LineasGuion();

            clsfactura.CreaTicket.EncabezadoVenta();
            clsfactura.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dgvlista.Rows)//Este código realiza las mismas validaciones que en el primer caso, pero esta vez dentro del bucle foreach que recorre las filas del DataGridView. Si alguna conversión falla, muestra un mensaje de error indicando en qué fila ocurrió el problema.
            {
                string nombreProducto = r.Cells[1].Value.ToString();
                if (!string.IsNullOrWhiteSpace(nombreProducto))
                {
                    double precioProducto;
                    if (double.TryParse(r.Cells[2].Value.ToString(), out precioProducto))
                    {
                        int cantidadProducto;
                        if (int.TryParse(r.Cells[3].Value.ToString(), out cantidadProducto))
                        {
                            double totalProducto = precioProducto * cantidadProducto;
                            r.Cells[4].Value = totalProducto.ToString();
                        }
                        else
                        {
                            MessageBox.Show("La cantidad en la fila " + (r.Index + 1) + " no es válida.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El precio en la fila " + (r.Index + 1) + " no es válido.");
                    }
                }
            }



            clsfactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(lbltotal.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtefectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lbldevolucion.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

            MessageBox.Show("Gracias por preferirnos, busca la factura en la carpeta documentos y abrela con el bloc de notas");
            // Al final del proceso, dispara el evento si la factura se generó con éxito
            FacturaGenerada = true;
            
        // Cierra Form2

        this.Close();
            
            
        }
    }
}
