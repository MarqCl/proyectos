/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package daehan.ejercicio.pkg5.pilas.examen;

import java.util.Scanner;
import java.util.Stack;

/**
 *
 * @author DICONSERV
 */
public class DaehanEjercicio5PilasExamen {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        
        Scanner scanner = new Scanner(System.in);
        String respuesta;
        
        do {
            Stack<String> productos = new Stack<>();
        
            productos.push("Producto 1");
            productos.push("Producto 2");
            productos.push("Producto 3");
            productos.push("Producto 4");
            productos.push("Producto 5");
            productos.push("Producto 6");
            productos.push("Producto 7");
            productos.push("Producto 8");
            productos.push("Producto 9");
            productos.push("Producto 10");
            
            // Recorrer la pila y solicitar al usuario el capital invertido en cada producto
            while (!productos.empty()) {
                String producto = productos.pop();
                System.out.print("Ingrese el capital invertido en " + producto + ": ");
                double capital = scanner.nextDouble();
                double inversion = capital * 0.15;
                System.out.println("La inversión del banco sobre el capital invertido en " + producto + " es de: " + inversion);
            }
            
            System.out.print("¿Desea reiniciar el programa? (s/n): ");
            respuesta = scanner.next();
        } while (respuesta.equalsIgnoreCase("s"));
        
        scanner.close();// Cerrar el objeto Scanner solo porque lei que era importante detener la lectura de datos cuando no se ocupa
    }                   //porque dice que esuna buena practica porque limpia memoria, no sirve de nada tenerlo activo si ya no se va a seguir usando

}

    
   
