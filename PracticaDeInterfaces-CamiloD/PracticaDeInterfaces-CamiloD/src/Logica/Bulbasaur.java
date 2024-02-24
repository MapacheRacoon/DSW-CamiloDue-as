
package Logica;     // Se declara el paquete al que pertenece la clase

public class Bulbasaur extends Pokemon implements IPlanta{   // Bulbasaur hereda de Pokemon e implementa la interfaz IPlanta

    public Bulbasaur() {            // Constructor de la clase

    }   
    
    @Override      // Se sobreescribe el método de la clase padre
    public void atacarPlacaje() {     // Método que se implementa de la interfaz IPlanta
        System.out.println("Bulbasaur usa ataque placaje");     // Método que se implementa de la interfaz IPlanta      
    }       

    @Override               // Se sobreescribe el método de la clase padre
    public void atacarAraniazo() {              // Método que se implementa de la interfaz IPlanta
        System.out.println("Bulbasaur usa ataque arañazo");         // Método que se implementa de la interfaz IPlanta     
    }

    @Override            // Se sobreescribe el método de la clase padre
    public void atacarMordisco() {      // Método que se implementa de la interfaz IPlanta
        System.out.println("Bulbasaur usa ataque mordisco");        // Método que se implementa de la interfaz IPlanta  
    }       

    @Override         // Se sobreescribe el método de la clase padre
    public void atacarDrenaje() {    // Método que se implementa de la interfaz IPlanta
        System.out.println("Bulbasaur usa ataque drenaje");     // Método que se implementa de la interfaz IPlanta
    }

    @Override       // Se sobreescribe el método de la clase padre
    public void atacarParalizar() {   // Método que se implementa de la interfaz IPlanta
        System.out.println("Bulbasaur usa ataque paralizar");       // Método que se implementa de la interfaz IPlanta
    }
    
}
