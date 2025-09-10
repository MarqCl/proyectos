//busqueda lineal ejemplo de buscar el nombre luis o nombres

package linearsearch.pkg31.pkg3.pkg23;

import java.util.Scanner;

/**
 *
 * @author DICONSERV
 */
public class LINEARSEARCH31323 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String[] names = new String[10];
        
        // Prompt the user to enter up to 10 names
        for (int i = 0; i < names.length; i++) {
            System.out.print("pon un nombre (o 's' para saltar este paso): ");
            String name = input.nextLine();
            if (name.equals("s")) {
                break;
            }
            names[i] = name;
        }
        
        // Prompt the user to enter a name to search for
        System.out.print("introduce el nombre a buscar: ");
        String nameToFind = input.nextLine();
        
        int index = linearSearch(names, nameToFind);
        
        if(index == -1) {
            System.out.println("Nombre no encontrado.");
        } else {
            System.out.println("nobre encontrado en el indice " + index);
        }
    }
    
    public static int linearSearch(String[] array, String key) {
        for(int i = 0; i < array.length; i++) {
            if(array[i] != null && array[i].equals(key)) {
                return i;
            }
        }
        return -1;
    }
    }
    

