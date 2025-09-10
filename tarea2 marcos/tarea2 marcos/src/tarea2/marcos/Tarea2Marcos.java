/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package tarea2.marcos;

/**
 *
 * @author DICONSERV
 */
import java.util.Scanner;

public class Tarea2Marcos {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        
        Scanner scanner = new Scanner(System.in);
        String respuesta;

        do {
            System.out.println("Programa de Gestión de Personas");
            System.out.println("Este programa le permite crear y gestionar información de personas.");
            System.out.print("¿Desea iniciar el programa? (Si/No): ");
            respuesta = scanner.next().toLowerCase(); // Convertir la respuesta a minúsculas

            if (respuesta.equals("si")) {
                System.out.println("Por favor, siga las instrucciones para ingresar información de la persona:");
                System.out.print("Ingrese los nombres de la persona: ");
                scanner.nextLine(); // Consumir la línea en blanco después del input anterior
                String nombres = scanner.nextLine();
                System.out.print("Ingrese la edad de la persona: ");
                int edad = scanner.nextInt();
                System.out.print("Ingrese el sexo de la persona (H hombre, M mujer, J jasmir): ");
                char sexo = scanner.next().charAt(0);

                Persona persona = new Persona(nombres, edad, sexo);

                System.out.println("Información de la persona:");
                System.out.println(persona);

                System.out.print("¿Desea reiniciar el programa? (Si/No): ");
                respuesta = scanner.next().toLowerCase();
            }
        } while (respuesta.equals("si"));

        scanner.close();
    }
}


