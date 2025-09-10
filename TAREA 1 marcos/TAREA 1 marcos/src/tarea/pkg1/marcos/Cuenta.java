/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package tarea.pkg1.marcos;

/**
 *
 * @author DICONSERV
 */
import java.util.Scanner;
public class Cuenta {
  
    private String titular;
    private double cantidad;

    // Constructor con ambos atributos: titular y cantidad
    public Cuenta(String titular, double cantidad) {
        this.titular = titular;
        this.cantidad = cantidad;
    }

    // Constructor sin cantidad (se inicializa en 0.0)
    public Cuenta(String titular) {
        this(titular, 0.0);
    }

    // Método Getter para el atributo titular
    public String getTitular() {
        return titular;
    }

    // Método Getter para el atributo cantidad
    public double getCantidad() {
        return cantidad;
    }

    // Método Setter para el atributo cantidad
    public void setCantidad(double cantidad) {
        this.cantidad = cantidad;
    }

    // Método para ingresar dinero a la cuenta
    public void ingresar(double cantidad) {
        if (cantidad > 0) {
            this.cantidad += cantidad;
        }
    }

    // Método para retirar dinero de la cuenta
    public void retirar(double cantidad) {
        if (cantidad > 0 && cantidad <= this.cantidad) {
            this.cantidad -= cantidad;
        }
    }

    // Método para obtener una representación en cadena de la cuenta
    @Override
    public String toString() {
        return "Cuenta de " + titular + " (Cantidad: " + cantidad + ")";
    }

    // Método principal utilizado solo para pruebas
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Ingrese el nombre del titular de la cuenta: ");
        String titular = scanner.nextLine();
        Cuenta cuenta = new Cuenta(titular);

        System.out.print("Ingrese la cantidad inicial en la cuenta: ");
        double cantidadInicial = scanner.nextDouble();
        cuenta.setCantidad(cantidadInicial);

        System.out.println("Estado inicial de la cuenta: " + cuenta);

        System.out.print("¿Cuánto dinero desea ingresar en la cuenta? ");
        double cantidadIngresar = scanner.nextDouble();
        cuenta.ingresar(cantidadIngresar);

        System.out.println("Estado de la cuenta después de ingresar dinero: " + cuenta);

        System.out.print("¿Cuánto dinero desea retirar de la cuenta? ");
        double cantidadRetirar = scanner.nextDouble();
        cuenta.retirar(cantidadRetirar);

        System.out.println("Estado final de la cuenta: " + cuenta);

        scanner.close();
    }
}







