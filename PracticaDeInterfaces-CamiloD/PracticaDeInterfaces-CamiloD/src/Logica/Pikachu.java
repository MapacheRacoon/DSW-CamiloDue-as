
package Logica;


public class Pikachu extends Pokemon implements IElectrico{ //implements IElectrico

    public Pikachu() { //Constructor

    } //Fin del constructor

    
    @Override //Sobreescribir el metodo de la clase padre
    protected void atacarPlacaje() { //Metodo de la clase padre
        System.out.println("Pikachu usa ataque placaje"); //Mensaje
    } //Fin del metodo

    @Override //Sobreescribir el metodo de la clase padre
    protected void atacarAraniazo() { //Metodo de la clase padre
        System.out.println("Pikachu usa ataque arañazo"); //Mensaje
    }

    @Override //Sobreescribir el metodo de la clase padre
    protected void atacarMordisco() { //Metodo de la clase padre
        System.out.println("Pikachu usa ataque mordisco"); //Mensaje
    } 

    @Override
    public void atacarImpactrueno() {
        System.out.println("Pikachu usa ataque impactrueno");
    }

    @Override
    public void atacarPunioTrueno() {
        System.out.println("Pikachu usa ataque puño trueno");
    }
    
} //Fin de la clase Pikachu
