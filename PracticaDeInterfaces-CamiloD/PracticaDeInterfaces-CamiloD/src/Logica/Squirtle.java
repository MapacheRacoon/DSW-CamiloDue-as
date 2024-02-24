
package Logica;


public class Squirtle extends Pokemon implements IAgua{ //Squirtle hereda de Pokemon e implementa la interfaz IAgua

    public Squirtle() { //Constructor de Squirtle
    
    } //Fin del constructor de Squirtle
   
    
    
    @Override //Sobreescribimos el metodo atacarPlacaje de la clase Pokemon
    protected void atacarPlacaje() { //Implementacion del metodo atacarPlacaje de la clase Pokemon
        System.out.println("Squirtle usa ataque placaje"); //Mensaje que se imprime al ejecutar el metodo atacarPlacaje
    } //Fin del metodo atacarPlacaje

    @Override
    protected void atacarAraniazo() { //Implementacion del metodo atacarAraniazo de la clase Pokemon
        System.out.println("Squirtle usa ataque arañazo"); //Mensaje que se imprime al ejecutar el metodo atacarAraniazo
    }

    @Override //Sobreescribimos el metodo atacarMordisco de la clase Pokemon
    protected void atacarMordisco() { //Implementacion del metodo atacarMordisco de la clase Pokemon
        System.out.println("Squirtle usa ataque mordisco"); //Mensaje que se imprime al ejecutar el metodo atacarMordisco
    }

    @Override
    public void atacarHidrobomba() { //Implementacion del metodo atacarHidrobomba de la interfaz IAgua
        System.out.println("Squirtle usa ataque hidrobomba"); //Mensaje que se imprime al ejecutar el metodo atacarHidrobomba
    }

    @Override
    public void atacarBurbuja() { //Implementacion del metodo atacarBurbuja de la interfaz IAgua
        System.out.println("Squirtle usa ataque burbuja"); //Mensaje que se imprime al ejecutar el metodo atacarBurbuja
    }

    @Override
    public void atacarPistolaAgua() { //Implementacion del metodo atacarPistolaAgua de la interfaz IAgua
        System.out.println("Squirtle usa ataque pistola agua"); //Mensaje que se imprime al ejecutar el metodo atacarPistolaAgua
    } 
    
    
} //Fin de la clase Squirtle
