
package Logica;    // esta clase esta en el package Logica


public class Charmander extends Pokemon implements IFuego{ // Charmander hereda de Pokemon e implementa IFuego

    public Charmander() { // constructor de Charmander
        super("Charmander"); // llama al constructor de la clase padre Pokemon
    } 

    
    @Override // sobreescribo el metodo de la clase padre
    protected void atacarPlacaje() { // implemento el metodo atacarPlacaje de la interfaz IPokemon
        System.out.println("Hola soy Charmander y este es mi ataque placaje"); // imprimo por pantalla
    }

    @Override // sobreescribo el metodo de la clase padre
    protected void atacarAraniazo() { // implemento el metodo atacarAraniazo de la interfaz IPokemon
        System.out.println("Charmander usa ataque arañazo"); // imprimo por pantalla
    } 

    @Override // sobreescribo el metodo de la clase padre
    protected void atacarMordisco() { // implemento el metodo atacarMordisco de la interfaz IFuego
        System.out.println("Charmander usa ataque mordisco"); // imprimo por pantalla
    }

    @Override // sobreescribo el metodo de la clase padre
    public void atacarPunioFuego() { // implemento el metodo atacarPunioFuego de la interfaz IFuego
        System.out.println("Charmander usa ataque puño fuego"); // imprimo por pantalla
    }

    @Override // sobreescribo el metodo de la clase padre
    public void atacarLanzallamas() {   // implemento el metodo atacarLanzallamas de la interfaz IFuego
        System.out.println("Charmander usa ataque lanzallamas"); // imprimo por pantalla
    }

    @Override // sobreescribo el metodo de la clase padre
    public void atacarAscuas() { // implemento el metodo atacarAscuas de la interfaz IFuego
        System.out.println("Charmander usa ataque ascuas"); // imprimo por pantalla
    } 
    
} // fin de la clase Charmander
