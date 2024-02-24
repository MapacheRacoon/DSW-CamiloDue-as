
package Logica;

public abstract class Pokemon { // Clase abstracta
    
    protected int numPokedex; // Atributos
    protected String nombre;  // Atributos
    protected double peso;   // Atributos
    protected String sexo;  // Atributos
    protected int temporada;  // Atributos
    
    protected abstract void atacarPlacaje(); // Metodos abstractos
    protected abstract void atacarAraniazo(); // Metodos abstractos
    protected abstract void atacarMordisco();   // Metodos abstractos
    
} // Fin de la clase abstracta Pokemon
