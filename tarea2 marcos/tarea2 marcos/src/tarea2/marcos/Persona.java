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
public class Persona {
     private String nombres;
    private int edad;
    private String DNI;
    private char sexo;
    private double peso;
    private double altura;

    public Persona(String nombres, int edad, char sexo) {
        this.nombres = nombres;
        this.edad = edad;
        this.sexo = comprobarSexo(sexo);
        this.DNI = generarDNI();
        this.peso = 0.0;
        this.altura = 0.0;
    }

    private char comprobarSexo(char sexo) {
        if (sexo == 'H' || sexo == 'M' || sexo == 'J') {
            return sexo;
        } else {
            return 'H'; // Por defecto, asignamos 'H' (Hombre) si el sexo es inválido.
        }
    }

    private String generarDNI() {
        // Aquí puedes implementar la generación de un número de DNI aleatorio o personalizado.
        // En este ejemplo, simplemente asignamos un valor por defecto.
        return "00000000X";
    }

    public String getNombres() {
        return nombres;
    }

    public void setNombres(String nombres) {
        this.nombres = nombres;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public char getSexo() {
        return sexo;
    }

    public void setSexo(char sexo) {
        this.sexo = comprobarSexo(sexo);
    }

    @Override
    public String toString() {
        return "Persona [Nombres: " + nombres + ", Edad: " + edad + ", DNI: " + DNI + ", Sexo: " + sexo
                + ", Peso: " + peso + ", Altura: " + altura + "]";
    }
}
