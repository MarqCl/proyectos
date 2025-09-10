/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package programaventavehiculos;

public class Vehiculo {
    private String modelo;
    private String marca;
    private String color;
    private int año;
    private double precio;
    private double kilo;
    private double metraje;
    private String caracteristicasAdicionales;

    // Constructor
    public Vehiculo(String modelo, String marca, String color, int año, double precio, double kilo, double metraje, String caracteristicasAdicionales) {
        this.modelo = modelo;
        this.marca = marca;
        this.color = color;
        this.año = año;
        this.precio = precio;
        this.kilo = kilo;
        this.metraje = metraje;
        this.caracteristicasAdicionales = caracteristicasAdicionales;
    }

    // Getters y setters para cada atributo
    public String getModelo() {
        return modelo;
    }

    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    public String getMarca() {
        return marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public int getAño() {
        return año;
    }

    public void setAño(int año) {
        this.año = año;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public double getKilo() {
        return kilo;
    }

    public void setKilo(double kilo) {
        this.kilo = kilo;
    }

    public double getMetraje() {
        return metraje;
    }

    public void setMetraje(double metraje) {
        this.metraje = metraje;
    }

    public String getCaracteristicasAdicionales() {
        return caracteristicasAdicionales;
    }

    public void setCaracteristicasAdicionales(String caracteristicasAdicionales) {
        this.caracteristicasAdicionales = caracteristicasAdicionales;
    }

    // Otros métodos si es necesario
}
