//hacer una base de datos de 5 personas con nombre, edad, sexo, peso y altura
//hacer que el  programa que muestre cuantas personas son mayores de edad y cuantas son menores de edad

import java.util.Scanner; //importar la clase Scanner para poder leer datos del teclado


public class Main { //clase principal
    public static void main(String[] args) { //metodo principal
        Scanner scanner = new Scanner(System.in); //crear un objeto de la clase Scanner
        String nombre; //declarar variable de tipo String
        int edad; //declarar variable de tipo entero
        char sexo; //declarar variable de tipo caracter
        double peso; //declarar variable de tipo double
        double altura; //declarar variable de tipo double
        int contadorMayorEdad = 0; //declarar variable de tipo entero
        int contadorMenorEdad = 0; //declarar variable de tipo entero
        int contadorHombres = 0; //declarar variable de tipo entero
        int contadorMujeres = 0; //declarar variable de tipo entero
        double promedioEdadMujeres = 0; //declarar variable de tipo double
        double promedioEdadHombres = 0; //declarar variable de tipo double
        double promedioPesoMujeres = 0; //declarar variable de tipo double
        double promedioPesoHombres = 0; //declarar variable de tipo double
        double promedioAlturaMujeres = 0; //declarar variable de tipo double
        double promedioAlturaHombres = 0; //declarar variable de tipo double
        double promedioPesoTotal = 0; //declarar variable de tipo double
        double promedioAlturaTotal = 0; //declarar variable de tipo double
        double promedioEdadTotal = 0; //declarar variable de tipo double
        int contadorPersonas = 0; //declarar variable de tipo entero
        int contadorPesoTotal = 0; //declarar variable de tipo entero
        int contadorAlturaTotal = 0; //declarar variable de tipo entero
        int contadorEdadTotal = 0; //declarar variable de tipo entero
        int contadorPesoMujeres = 0; //declarar variable de tipo entero
        int contadorPesoHombres = 0; //declarar variable de tipo entero
        int contadorAlturaMujeres = 0; //declarar variable de tipo entero
        int contadorAlturaHombres = 0; //declarar variable de tipo entero
        int contadorEdadMujeres = 0; //declarar variable de tipo entero
        int contadorEdadHombres = 0; //declarar variable de tipo entero
        int contadorPesoHombresTotal = 0; //declarar variable de tipo entero
        int contadorPesoMujeresTotal = 0; //declarar variable de tipo entero
        int contadorAlturaHombresTotal = 0; //declarar variable de tipo entero
        int contadorAlturaMujeresTotal = 0; //declarar variable de tipo entero
        int contadorEdadHombresTotal = 0; //declarar variable de tipo entero
        int contadorEdadMujeresTotal = 0; //declarar variable de tipo entero
        int contadorHombresTotal = 0; //declarar variable de tipo entero
        int contadorMujeresTotal = 0; //declarar variable de tipo entero
        for (int i = 0; i < 5; i++) { //ciclo for para pedir los datos de las 5 personas
            System.out.println("Ingrese el nombre de la persona " + (i + 1)); //pedir el nombre de la persona
            nombre = scanner.nextLine(); //leer el nombre de la persona
            System.out.println("Ingrese la edad de la persona " + (i + 1)); //pedir la edad de la persona
            edad = scanner.nextInt(); //leer la edad de la persona
            System.out.println("Ingrese el sexo de la persona " + (i + 1)); //pedir el sexo de la persona
            sexo = scanner.next().charAt(0); //leer el sexo de la persona
            System.out.println("Ingrese el peso de la persona " + (i + 1)); //pedir el peso de la persona
            peso = scanner.nextDouble(); //leer el peso de la persona
            System.out.println("Ingrese la altura de la persona " + (i + 1)); //pedir la altura de la persona
            altura = scanner.nextDouble(); //leer la altura de la persona
            if (edad >= 18) { //si la edad es mayor o igual a 18
                contadorMayorEdad++; //aumentar el contador de personas mayores de edad
            } else { //si no
                contadorMenorEdad++; //aumentar el contador de personas menores de edad
            }  //fin del if
