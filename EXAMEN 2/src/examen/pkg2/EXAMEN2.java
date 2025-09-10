/*
//julissa y marcos. ing en sistemas 2do año - estructura de datos 2-6-2023.
 El código proporcionado parece estar libre de errores de sintaxis. Describe un programa en Java que realiza operaciones en un arreglo bidimensional.

El programa comienza solicitando al usuario el número de filas y columnas del arreglo. Luego, se crea un arreglo bidimensional con las dimensiones proporcionadas.

A continuación, se muestra un menú de opciones con diferentes operaciones que se pueden realizar en el arreglo. El programa lee la opción ingresada por el usuario y realiza la operación correspondiente utilizando los métodos definidos en la clase.

Aquí están las operaciones que se pueden realizar:

1. Imprimir el arreglo: Imprime todos los elementos del arreglo bidimensional.
2. Imprimir la diagonal principal: Imprime los elementos en la diagonal principal del arreglo.
3. Imprimir los elementos debajo de la diagonal inversa: Imprime los elementos debajo de la diagonal inversa del arreglo.
4. Imprimir los elementos encima de la diagonal principal: Imprime los elementos encima de la diagonal principal del arreglo.
5. Imprimir los elementos encima de la diagonal inversa: Imprime los elementos encima de la diagonal inversa del arreglo.
6. Sumar los elementos de una fila: Solicita al usuario el número de una fila y suma todos los elementos de esa fila.
7. Sumar los elementos de una columna: Solicita al usuario el número de una columna y suma todos los elementos de esa columna.
8. Sumar todos los elementos del arreglo: Suma todos los elementos del arreglo completo.
9. Determinar el elemento mayor y su posición: Encuentra el elemento mayor en el arreglo y muestra su valor y posición.
10. Determinar el elemento menor y su posición: Encuentra el elemento menor en el arreglo y muestra su valor y posición.
11. Determinar el elemento mayor de cada fila y su posición: Encuentra el elemento mayor en cada fila y muestra su valor y posición.
12. Determinar el elemento menor de cada fila y su posición: Encuentra el elemento menor en cada fila y muestra su valor y posición.
15. Salir: Termina la ejecución del programa.

El programa utiliza métodos específicos para realizar cada una de las operaciones. Estos métodos toman el arreglo bidimensional como parámetro y realizan las operaciones correspondientes.

En general, el código parece estar bien estructurado y ofrece una funcionalidad completa para trabajar con arreglos bidimensionales y realizar diferentes operaciones en ellos.
 */

package examen.pkg2;

import java.util.Scanner;
public class EXAMEN2 {

   
    public static void main(String[] args) {
        
        Scanner scanner = new Scanner(System.in);
        
        // Lectura de las dimensiones del arreglo
        System.out.print("Ingrese el número de filas: ");
        int filas = scanner.nextInt();
        System.out.print("Ingrese el número de columnas: ");
        int columnas = scanner.nextInt();
        
        double[][] arreglo = new double[filas][columnas];
        
        // Lectura de los elementos del arreglo
        System.out.println("Ingrese los elementos del arreglo:");
        for (int i = 0; i < filas; i++) {
            for (int j = 0; j < columnas; j++) {
                System.out.print("Ingrese el elemento en la posición [" + i + "][" + j + "]: ");
                arreglo[i][j] = scanner.nextDouble();
            }
        }
        
        int opcion;
        do {
            // Menú de opciones
            System.out.println("         menu de opciones:" );    
            System.out.println("");
            System.out.println("1. Imprimir el arreglo");
            System.out.println("2. Imprimir la diagonal principal");
            System.out.println("3. Imprimir los elementos debajo de la diagonal inversa");
            System.out.println("4. Imprimir los elementos encima de la diagonal principal");
            System.out.println("5. Imprimir los elementos encima de la diagonal inversa");
            System.out.println("6. Sumar los elementos de una fila");
            System.out.println("7. Sumar los elementos de una columna");
            System.out.println("8. Sumar todos los elementos del arreglo");
            System.out.println("9. Determinar el elemento mayor y su posición");
            System.out.println("10. Determinar el elemento menor y su posición");
            System.out.println("11. Determinar el elemento mayor de cada fila y su posición");
            System.out.println("12. Determinar el elemento menor de cada fila y su posición");
            System.out.println("15. Salir");
            System.out.print("Ingrese una opción: ");
            opcion = scanner.nextInt();
            
            switch (opcion) {
                case 1:
                    System.out.println("El arreglo es:");
                    imprimirArreglo(arreglo);
                    break;
                case 2:
                    System.out.println("La diagonal principal es:");
                    imprimirDiagonalPrincipal(arreglo);
                    break;
                case 3:
                    System.out.println("Los elementos debajo de la diagonal inversa son:");
                    imprimirDebajoDiagonalInversa(arreglo);
                    break;
                case 4:
                    System.out.println("Los elementos encima de la diagonal principal son:");
                    imprimirEncimaDiagonalPrincipal(arreglo);
                    break;
                case 5:
                    System.out.println("Los elementos encima de la diagonal inversa son:");
                    imprimirEncimaDiagonalInversa(arreglo);
                    break;
                case 6:
                    System.out.print("Ingrese el número de la fila a sumar: ");
                    int fila = scanner.nextInt();
                    double sumaFila = sumarFila(arreglo, fila);
                    System.out.println("La suma de los elementos de la fila " + fila + " es: " + sumaFila);
                    break;
                case 7:
                    System.out.print("Ingrese el número de la columna a sumar: ");
                    int columna = scanner.nextInt();
                    double sumaColumna = sumarColumna(arreglo, columna);
                    System.out.println("La suma de los elementos de la columna " + columna + " es: " + sumaColumna);
                    break;
                case 8:
                    double sumaArreglo = sumarArreglo(arreglo);
                    System.out.println("La suma de todos los elementos del arreglo es: " + sumaArreglo);
                    break;
                case 9:
                    double[] elementoMayorYPosicion = encontrarElementoMayor(arreglo);
                    System.out.println("El elemento mayor del arreglo es: " + elementoMayorYPosicion[0]);
                    System.out.println("Su posición es: [" + (int)elementoMayorYPosicion[1] + "][" + (int)elementoMayorYPosicion[2] + "]");
                    break;
                case 10:
                    double[] elementoMenorYPosicion = encontrarElementoMenor(arreglo);
                    System.out.println("El elemento menor del arreglo es: " + elementoMenorYPosicion[0]);
                    System.out.println("Su posición es: [" + (int)elementoMenorYPosicion[1] + "][" + (int)elementoMenorYPosicion[2] + "]");
                    break;
                case 11:
                    System.out.println("Los elementos mayores de cada fila son:");
                    encontrarElementosMayoresPorFila(arreglo);
                    break;
                case 12:
                    System.out.println("Los elementos menores de cada fila son:");
                    encontrarElementosMenoresPorFila(arreglo);
                    break;
                case 13:
                    System.out.println("Los elementos mayores de cada fila son:");
                encontrarElementosMayoresPorFila(arreglo);
                    break;
                    case 14:
                    System.out.println("Los elementos menores de cada fila son:");
                    encontrarElementosMenoresPorFila(arreglo);
                    break;
                case 15:
                    System.out.println("Saliendo del programa...");
                    break;
                default:
                    System.out.println("Opción inválida. Intente nuevamente.");
                    break;
            }
        } while (opcion != 15);
        
        scanner.close();
    }
    
    // Método para imprimir el arreglo completo
    public static void imprimirArreglo(double[][] arreglo) {
        for (int i = 0; i < arreglo.length; i++) {
            for (int j = 0; j < arreglo[i].length; j++) {
                System.out.print(arreglo[i][j] + " ");
            }
            System.out.println();
        }
    }
    
    // Método para imprimir la diagonal principal
    public static void imprimirDiagonalPrincipal(double[][] arreglo) {
        for (int i = 0; i < arreglo.length; i++) {
            System.out.print(arreglo[i][i] + " ");
        }
        System.out.println();
    }
    
    // Método para imprimir los elementos debajo de la diagonal inversa
    public static void imprimirDebajoDiagonalInversa(double[][] arreglo) {
        for (int i = 0; i < arreglo.length; i++) {
            for (int j = 0; j < i; j++) {
                System.out.print(arreglo[i][j] + " ");
            }
        }
        System.out.println();
    }
    
    // Método para imprimir los elementos encima de la diagonal principal
    public static void imprimirEncimaDiagonalPrincipal(double[][] arreglo) {
        for (int i = 0; i < arreglo.length; i++) {
            for (int j = i + 1; j < arreglo[i].length; j++) {
                System.out.print(arreglo[i][j] + " ");
            }
        }
        System.out.println();
    }
    
    // Método para imprimir los elementos encima de la diagonal inversa
    public static void imprimirEncimaDiagonalInversa(double[][] arreglo) {
        for (int i = 0; i < arreglo.length; i++) {
            for (int j = 0; j < arreglo[i].length; j++) {
                if (j < i) {
                    System.out.print(arreglo[i][j] + " ");
                }
            }
        }
        System.out.println();
    }

    // Método para sumar los elementos de una fila dada
    public static double sumarFila(double[][] arreglo, int fila) {
        double suma = 0;
        for (int j = 0; j < arreglo[fila].length; j++) {
            suma += arreglo[fila][j];
        }
        return suma;
    }

    // Método para sumar los elementos de una columna dada
    public static double sumarColumna(double[][] arreglo, int columna) {
        double suma = 0;
        for (int i = 0; i < arreglo.length; i++) {
            suma += arreglo[i][columna];
        }
        return suma;
    }

    // Método para sumar todos los elementos del arreglo completo
    public static double sumarArreglo(double[][] arreglo) {
        double suma = 0;
        for (int i = 0; i < arreglo.length; i++) {
            for (int j = 0; j < arreglo[i].length; j++) {
                suma += arreglo[i][j];
            }
        }
        return suma;
    }

    // Método para encontrar el elemento mayor del arreglo y su posición
    public static double[] encontrarElementoMayor(double[][] arreglo) {
        double mayor = arreglo[0][0];
        int filaMayor = 0;
        int columnaMayor = 0;
        for (int i = 0; i < arreglo.length; i++) {
            for (int j = 0; j < arreglo[i].length; j++) {
                if (arreglo[i][j] > mayor) {
                    mayor = arreglo[i][j];
                    filaMayor = i;
                    columnaMayor = j;
                }
            }
        }
        double[] resultado = { mayor, filaMayor, columnaMayor };
        return resultado;
    }

    // Método para encontrar el elemento menor del arreglo y su posición
    public static double[] encontrarElementoMenor(double[][] arreglo) {
        double menor = arreglo[0][0];
        int filaMenor = 0;
        int columnaMenor = 0;
        for (int i = 0; i < arreglo.length; i++) {
            for (int j = 0; j < arreglo[i].length; j++) {
                if (arreglo[i][j] < menor) {
                    menor = arreglo[i][j];
                    filaMenor = i;
                    columnaMenor = j;
                }
            }
        }
        double[] resultado = { menor, filaMenor, columnaMenor };
        return resultado;
    }

    // Método para encontrar el elemento mayor de cada fila y su posición
    public static void encontrarElementosMayoresPorFila(double[][] arreglo) {
        for (int i = 0; i < arreglo.length; i++) {
            double mayor = arreglo[i][0];
            int columnaMayor = 0;
            for (int j = 1; j < arreglo[i].length; j++) {
                if (arreglo[i][j] > mayor) {
                    mayor = arreglo[i][j];
                    columnaMayor = j;
                }
            }
            System.out.println("El elemento mayor de la fila " + i + " es: " + mayor);
            System.out.println("Su posición es: [" + i + "][" + columnaMayor + "]");
        }
    }

    // Método para encontrar el elemento menor de cada fila y su posición
    public static void encontrarElementosMenoresPorFila(double[][] arreglo) {
        for (int i = 0; i < arreglo.length; i++) {
            double menor = arreglo[i][0];
            int columnaMenor = 0;
            for (int j = 1; j < arreglo[i].length; j++) {
                if (arreglo[i][j] < menor) {
                    menor = arreglo[i][j];
                    columnaMenor = j;
                }
            }
            System.out.println("El elemento menor de la fila " + i + " es: " + menor);
            System.out.println("Su posición es: [" + i + "][" + columnaMenor + "]");
        }
    }
    
}
