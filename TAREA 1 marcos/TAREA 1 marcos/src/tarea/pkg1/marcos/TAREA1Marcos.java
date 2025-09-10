package tarea.pkg1.marcos;

/**
 *
 * @author DICONSERV
 */
    import java.util.Scanner;

public class TAREA1Marcos {

    /**
     * @param args the command line arguments
     */
    
    public static void main(String[] args) {
        // TODO code application logic here
        
        Scanner scanner = new Scanner(System.in);
        String respuesta;

        do {
            System.out.println("Programa de Gestión de Cuentas Bancarias");
            System.out.println("Este programa le permite crear y gestionar cuentas bancarias.");
            System.out.print("¿Desea iniciar el programa? (Si/No): ");
            respuesta = scanner.next().toLowerCase(); // Convertir la respuesta a minúsculas

            if (respuesta.equals("si")) {
                System.out.println("Por favor, siga las instrucciones para crear cuentas y realizar operaciones.");

                // Ingresar datos para la primera cuenta
                System.out.print("Ingrese el nombre del titular de la primera cuenta: ");
                scanner.nextLine(); // Consumir la línea en blanco después del input anterior
                String titularCuenta1 = scanner.nextLine();
                System.out.print("Ingrese la cantidad inicial en la primera cuenta: ");
                double cantidadInicialCuenta1 = scanner.nextDouble();

                // Ingresar datos para la segunda cuenta
                System.out.print("Ingrese el nombre del titular de la segunda cuenta: ");
                scanner.nextLine(); // Consumir la línea en blanco después del input anterior
                String titularCuenta2 = scanner.nextLine();
                System.out.print("Ingrese la cantidad inicial en la segunda cuenta: ");
                double cantidadInicialCuenta2 = scanner.nextDouble();

                // Crear las cuentas con los datos ingresados por el usuario
                Cuenta cuenta1 = new Cuenta(titularCuenta1, cantidadInicialCuenta1);
                Cuenta cuenta2 = new Cuenta(titularCuenta2, cantidadInicialCuenta2);

                System.out.println("Estado de las cuentas iniciales:");
                System.out.println(cuenta1);
                System.out.println(cuenta2);

                // Realizar operaciones en las cuentas
                System.out.print("¿Cuánto dinero desea ingresar en la primera cuenta? ");
                double cantidadIngresarCuenta1 = scanner.nextDouble();
                cuenta1.ingresar(cantidadIngresarCuenta1);

                System.out.print("¿Cuánto dinero desea retirar de la segunda cuenta? ");
                double cantidadRetirarCuenta2 = scanner.nextDouble();
                cuenta2.retirar(cantidadRetirarCuenta2);

                System.out.println("Estado de las cuentas después de las operaciones:");
                System.out.println(cuenta1);
                System.out.println(cuenta2);

                // Preguntar si desea volver a usar el programa
                System.out.print("¿Desea volver a usar el programa? (Si/No): ");
                respuesta = scanner.next().toLowerCase();
            }
        } while (respuesta.equals("si"));

        scanner.close();
    }
}






        
 


   