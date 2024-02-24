package conexion;

import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author cadd9
 */
public class Conexion {

    private Connection con;

    public void establecerConexion(){

        String host = "localhost";
        String user = "root";
        String pass = "12345edc"; 
        String db = "CeadIbague";

        try {
            String driver = "com.mysql.jdbc.Driver";
            String url = "jdbc:mysql://" + host + "/" + db;
            Class.forName(driver);

            con = DriverManager.getConnection(url, user, pass); 
            System.out.println("Conexión exitosa");

        } catch(Exception e) {
            System.out.println("Error de conexión " + e.getMessage());
        }

    }
    
    public void cerrarConexion() {
        
        try {
            con.close();
            System.out.println("Conexión cerrada");
            
        } catch(Exception e) {
            System.out.println("Error al cerrar conexión " + e.getMessage());
        }
        
    }

}