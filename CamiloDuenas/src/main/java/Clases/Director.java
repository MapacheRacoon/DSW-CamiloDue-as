/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Clases;

/**
 *
 * @author cadd9
 */
public class Director extends Permiso {
public class Permiso {
    public int idPermiso;
    public String FechaInicio;
    public String FechaFin;
    public String Motivo;
    public String Estado;
    }
public class Permiso {
    public int idPermiso;
    public String FechaInicio;
    public String FechaFin;
    public String Motivo;
    public String Estado;
}
public void rechazarPermiso() throws SQLException{
    String sql="UPDATE Permiso SET idPermiso=?, FechaInicio=?, FechaFin=?, Motivo=?, Estado=? WHERE idPermiso=?";
    PreparedStatement ps=conex.con.prepareStatement(sql:seleccion);
    ps.setInt(1, idPermiso);
    ps.setString(2, FechaInicio);
    ps.setString(3, FechaFin);
    ps.setString(4, Motivo);
    ps.setString(5, Estado);
    ps.executeUpdate();
    JOptionPane.showMessageDialog(null, "Permiso rechazado exitosamente");
} 
public void aceptarPermiso() throws SQLException{
    String sql="UPDATE Permiso SET idPermiso=?, FechaInicio=?, FechaFin=?, Motivo=?, Estado=? WHERE idPermiso=?";
    PreparedStatement ps=conex.con.prepareStatement(sql:seleccion);
    ps.setInt(1, idPermiso);
    ps.setString(2, FechaInicio);
    ps.setString(3, FechaFin);
    ps.setString(4, Motivo);
    ps.setString(5, Estado);
    ps.executeUpdate();
}
    public Director(int idFuncionario, String NombreCompleto, String FechaInicio, String FechaFin, String Motivo, String Estado, int id, String nombre, String apellido, String documentoIdentidad, String cargo, String correo, String telefono) {
        super(idFuncionario, NombreCompleto, FechaInicio, FechaFin, Motivo, Estado, id, nombre, apellido, documentoIdentidad, cargo, correo, telefono);
    }

    public void setIdFuncionario(int idFuncionario) {
        this.idFuncionario = idFuncionario;
    }

 
    
}
