/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package tarea3.marcos;
import java.util.Scanner;
/**
 *
 * @author DICONSERV
 */
public class Tarea3Marcos {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        Scanner scanner = new Scanner(System.in);
        String respuesta;

        do {
            System.out.println("Programa de Gestión de Contraseñas");
            System.out.println("Este programa le permite generar o utilizar una contraseña personalizada de longitud 8 caracteres.");

            boolean respuestaValida;
            do {
                System.out.print("¿Desea iniciar el programa? (Si/No): ");
                respuesta = scanner.next().toLowerCase();
                respuestaValida = respuesta.equals("si") || respuesta.equals("no");

                if (!respuestaValida) {
                    System.out.println("Respuesta incorrecta. Por favor, responda 'Si' o 'No'.");
                }
            } while (!respuestaValida);

            if (respuesta.equals("si")) {
                System.out.println("Por favor, siga las instrucciones para generar o utilizar una contraseña:");
                
                boolean ingresarContrasena;
                do {
                    System.out.print("¿Desea ingresar una contraseña personalizada? (Si/No): ");
                    String ingresarContrasenaStr = scanner.next().toLowerCase();
                    ingresarContrasena = ingresarContrasenaStr.equals("si") || ingresarContrasenaStr.equals("no");

                    if (!ingresarContrasena) {
                        System.out.println("Respuesta incorrecta. Por favor, responda 'Si' o 'No'.");
                    }
                } while (!ingresarContrasena);

                String contrasena;
                if (ingresarContrasena) {
                    System.out.print("Ingrese la contraseña (longitud 8 caracteres): ");
                    contrasena = scanner.next();

                    if (contrasena.length() != 8) {
                        System.out.println("La contraseña debe tener exactamente 8 caracteres. Inténtelo de nuevo.");
                        continue;
                    }
                } else {
                    contrasena = generarContrasenaPorDefecto();
                }

                System.out.println("Contraseña registrada: " + contrasena);

                boolean reiniciar;
                do {
                    System.out.print("¿Desea reiniciar el programa? (Si/No): ");
                    String reiniciarStr = scanner.next().toLowerCase();
                    reiniciar = reiniciarStr.equals("si") || reiniciarStr.equals("no");

                    if (!reiniciar) {
                        System.out.println("Respuesta incorrecta. Por favor, responda 'Si' o 'No'.");
                    }
                } while (!reiniciar);

                respuesta = reiniciar ? "si" : "no"; // Forzar reinicio si el usuario responde "si"
            }
        } while (respuesta.equals("si"));

        scanner.close();
    }

    public static String generarContrasenaPorDefecto() {
        return "12345678"; // Contraseña por defecto de longitud 8 caracteres
    }
}

    