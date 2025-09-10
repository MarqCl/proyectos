/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package programaventavehiculos;
public class Factura {
    private Cliente cliente;
    private Vendedor vendedor;
    private Vehiculo vehiculo;
    private double precioTotal;

    // Constructor
    public Factura(Cliente cliente, Vendedor vendedor, Vehiculo vehiculo) {
        this.cliente = cliente;
        this.vendedor = vendedor;
        this.vehiculo = vehiculo;
    }

    // Método para calcular el precio total
    public void calcularPrecioTotal() {
        // Lógica para calcular precio total, intereses, cuotas, etc.
        // Supongamos que aquí realizas los cálculos necesarios
        this.precioTotal = vehiculo.getPrecio() * 1.20;  // Agregando un 20% al precio
    }

    // Método para mostrar la factura al usuario
    public void mostrarFactura() {
        // Mostrar información de la factura
        System.out.println("----- Factura -----");
        System.out.println("Cliente: " + cliente.getNombre());
        System.out.println("Vendedor: " + vendedor.getNombre());
        System.out.println("Vehículo: " + vehiculo.getModelo());
        System.out.println("Precio Total: $" + precioTotal);
        System.out.println("Agregando un 20% al precio");
        // Puedes agregar más detalles según sea necesario
    }

    // Otros métodos si es necesario
}

