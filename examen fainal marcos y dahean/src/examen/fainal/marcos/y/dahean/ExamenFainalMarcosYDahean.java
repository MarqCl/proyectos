/*
 programa para comprar en una perrera
 */
package examen.fainal.marcos.y.dahean;

import java.util.Scanner;

/**
 *
 * @author DICONSERV
 */
public class ExamenFainalMarcosYDahean {

    /**
     * @param args the command line arguments
     *
     */
    static void lista() {
        //estos son arreglos y la lista de razas :
        int nperros;
        int r2=0;
        int r3 = 0;//significa respuesta 3
        int vr = 0; //variacion de la respuesta(esta lo usamos para el while para que vuelva a mostrar la lista)

        String[] perros = {""//este para que no comience desde 0
            , "Chow chow",
            "pincher",
            "Chihuahua",
            "Perro salchicha",
            "Stanford",
            "Sabueso"};

        do {
            System.out.println("");
            System.out.println("ok, este es el listado de las razas:");

            for (int i = 1; i < perros.length; i++)//length para que compruebe el maximo de las razas y asii no estar especificando el numero cuando querramos agregar o quitar una
            //este for es unicamente para enumerar y mostrar el nombre de los perros
            {
                System.out.println(i + ". " + perros[i]);
            }

            Scanner entrada = new Scanner(System.in);
            System.out.println("");
            System.out.print("escribe el numero segun el que quieres: ");

            r2 = entrada.nextInt();//r2 significa respuesta 2
            switch (r2) {
                case 1:
                    System.out.println("chow chow" + ": 60$");
                    System.out.println("");
                    System.out.println("deseas comprarlo?(si=1, no=2");
                    do {
                        System.out.print("escribe un numero para responder: ");
                        r3 = entrada.nextInt();//r2 significa respuesta 2
                        switch (r3) {
                            case 1:
                                System.out.println("has comprado un: " + "chow chow");
                                break;//en caso que si
                            case 2:
                                resraza();
                                break;// en caso que no
                            default:
                                r3 = 0;break;
                        }
                        

                    } while (r3 == 0);break;
                case 2:
                    System.out.println("pincher" + ": 50$");
                    System.out.println("");
                    System.out.println("deseas comprarlo?(si=1, no=2");
                    do {
                        System.out.print("escribe un numero para responder: ");
                        r3 = entrada.nextInt();//r2 significa respuesta 2
                        switch (r3) {
                            case 1:
                                System.out.println("has comprado un: " + "pincher");
                                break;//en caso que si
                            case 2:
                                resraza();
                                break;// en caso que no
                            default:
                                r3 = 0;break;
                        }
                        

                    } while (r3 == 0);break;
                case 3:
                    System.out.println("chihuahua" + ": 80$");
                    System.out.println("");
                    System.out.println("deseas comprarlo?(si=1, no=2");
                    do {
                        System.out.print("escribe un numero para responder: ");
                        r3 = entrada.nextInt();//r2 significa respuesta 2
                        switch (r3) {
                            case 1:
                                System.out.println("has comprado un: " + "chihuahua");
                                break;//en caso que si
                            case 2:
                                resraza();
                                break;// en caso que no
                            default:
                                r3 = 0;break;
                        }
                        

                    } while (r3 == 0);break;
                case 4:
                    System.out.println("perro salchicha" + ": 40$");
                    System.out.println("");
                    System.out.println("deseas comprarlo?(si=1, no=2");
                    do {
                        System.out.print("escribe un numero para responder: ");
                        r3 = entrada.nextInt();//r2 significa respuesta 2
                        switch (r3) {
                            case 1:
                                System.out.println("has comprado un: " + "perro salchicha");
                                break;//en caso que si
                            case 2:
                                resraza();
                                break;// en caso que no
                            default:
                                r3 = 0;break;
                        }
                        

                    } while (r3 == 0);break;
                case 5:
                    System.out.println("Stanford" + ": 100$");
                    System.out.println("");
                    System.out.println("deseas comprarlo?(si=1, no=2");
                    do {
                        System.out.print("escribe un numero para responder: ");
                        r3 = entrada.nextInt();//r2 significa respuesta 2
                        switch (r3) {
                            case 1:
                                System.out.println("has comprado un: " + "Stanford");
                                break;//en caso que si
                            case 2:
                                resraza();
                                break;// en caso que no
                            default:
                                r3 = 0;break;
                        }
                        

                    } while (r3 == 0);break;
                case 6:
                    System.out.println("sabueso" + ": 200$");
                    System.out.println("");
                    System.out.println("deseas comprarlo?(si=1, no=2");
                    do {
                        System.out.print("escribe un numero para responder: ");
                        r3 = entrada.nextInt();//r2 significa respuesta 2
                        switch (r3) {
                            case 1:
                                System.out.println("has comprado un: " + "sabueso");
                                break;//en caso que si
                            case 2:
                                resraza();
                                break;// en caso que no
                            default:
                                r3 = 0;break;
                        }
                        

                    } while (r3 == 0);break;
            }

        } while (r2 == 0);//valor respuesta
r2=0;
    }

    static void resraza() {//respuesta de raza
        System.out.println("");
        int r1 = 0;//r1 significa respuesta 1
        Scanner entrada = new Scanner(System.in);
        do {
            System.out.println("quieres ver las razas? \n1:si \n2:no");
            System.out.print("escribe el numero segun la opcion: ");
            r1 = entrada.nextInt();

            switch (r1) {
                case 1:
                    lista();
                    break;

                case 2:
                    System.out.println("");
                    System.out.println("gracias por preferirnos se detendra el programa");
                    break;
                default:
                    System.out.println("respuesta incorrecta");
                    System.out.println("");
                    r1 = 0;
                    break;
            }

        } while (r1 == 0);

    }

    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);

        int r2 = 0;

        System.out.println("esta es una tienda de perros");

        System.out.println("");
        System.out.println("que edad tienes?");

        System.out.print("responde solo en numeros: ");
        int edad = entrada.nextInt();
        if (edad >= 18) {

            resraza();//pregunta sobre ver las razas

            //   while()
        } else {
            System.out.println("no eres mayor de edad");
        }

    }

}
