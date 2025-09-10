 import java.util.Scanner;
import programaventavehiculos.Cliente;
import programaventavehiculos.Factura;
import programaventavehiculos.Vehiculo;
import programaventavehiculos.Vendedor;

import java.util.Scanner;

public class ProgramaVentaVehiculos {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Interacción con el usuario
        System.out.println("Bienvenido al programa de venta de vehículos.");

        // Crear instancia de Cliente
        Cliente cliente = crearCliente(scanner);
        
        // Crear instancia de Vendedor
        Vendedor vendedor = crearVendedor(scanner);
        
        // Crear instancia de Vehiculo
        Vehiculo vehiculo = crearVehiculo(scanner);

        // Crear instancia de Factura
        Factura factura = new Factura(cliente, vendedor, vehiculo);

        // Calcular precio total y mostrar factura
        factura.calcularPrecioTotal();
        factura.mostrarFactura();

        // Cierre del scanner al final del programa
        scanner.close();
    }

    // Método para crear un objeto Cliente con datos ingresados por el usuario
    private static Cliente crearCliente(Scanner scanner) {
        System.out.println("Ingrese el nombre del cliente:");
        String nombreCliente = scanner.nextLine();
        return new Cliente(nombreCliente);
    }

    // Método para crear un objeto Vendedor con datos ingresados por el usuario
    private static Vendedor crearVendedor(Scanner scanner) {
        System.out.println("Ingrese el nombre del vendedor:");
        String nombreVendedor = scanner.nextLine();
        return new Vendedor(nombreVendedor);
    }

    // Método para crear un objeto Vehiculo con datos ingresados por el usuario
    private static Vehiculo crearVehiculo(Scanner scanner) {
        System.out.println("Ingrese el modelo del vehículo:");
        String modelo = scanner.nextLine();

        System.out.println("Ingrese la marca del vehículo:");
        String marca = scanner.nextLine();

        System.out.println("Ingrese el color del vehículo:");
        String color = scanner.nextLine();

        System.out.println("Ingrese el año del vehículo:");
        int año = scanner.nextInt();
        scanner.nextLine(); // Limpiar el buffer

        System.out.println("Ingrese el precio del vehículo:");
        double precio = scanner.nextDouble();
        scanner.nextLine(); // Limpiar el buffer

        System.out.println("Ingrese el kilometraje del vehículo:");
        double kilo = scanner.nextDouble();
        scanner.nextLine(); // Limpiar el buffer

        System.out.println("Ingrese el metraje del vehículo:");
        double metraje = scanner.nextDouble();
        scanner.nextLine(); // Limpiar el buffer

        System.out.println("Ingrese características adicionales del vehículo:");
        String caracteristicasAdicionales = scanner.nextLine();

        return new Vehiculo(modelo, marca, color, año, precio, kilo, metraje, caracteristicasAdicionales);
        
    }
}
