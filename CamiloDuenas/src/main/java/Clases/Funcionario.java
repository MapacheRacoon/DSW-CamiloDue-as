/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Clases;

/**
 *
 * @author cadd9
 */

public class Funcionario {
    
    public int idFuncionario;
    public String nombre;
    public String apellido;
    public String documentoIdentidad;
    public String cargo;
    public String correo;
    public String telefono;

    public Funcionario(int id, String nombre, String apellido, String documentoIdentidad, String cargo, String correo, String telefono) {
        this.idFuncionario = id;
        this.nombre = nombre;
        this.apellido = apellido;
        this.documentoIdentidad = documentoIdentidad;
        this.cargo = cargo;
        this.correo = correo; 
        this.telefono = telefono;
    
    }

public void insertarFuncionario() throws SQLException {
        String sql = "INSERT INTO Funcionario (idFuncionario, nombre, apellido, documentoIdentidad, cargo, correo, telefono) VALUES (?,?,?,?,?,?,?)";
        PreparedStatement ps = con.prepareStatement(sql);
        ps.setInt(1, idFuncionario);
        ps.setString(2, nombre);
        ps.setString(3, apellido);
        ps.setString(4, documentoIdentidad);
        ps.setString(5, cargo);
        ps.setString(6, correo);
        ps.setString(7, telefono);
        ps.executeUpdate();
    }

public void actualizarFuncionario() throws SQLException {
        String sql = "UPDATE Funcionario SET nombre=?, apellido=?, documentoIdentidad=?, cargo=?, correo=?, telefono=? WHERE idFuncionario=?";
        PreparedStatement ps = con.prepareStatement(sql); 
        ps.setString(1, nombre);
        ps.setString(2, apellido);
        ps.setString(3, documentoIdentidad);
        ps.setString(4, cargo);
        ps.setString(5, correo);
        ps.setString(6, telefono);
        ps.setInt(7, idFuncionario);
        ps.executeUpdate();
    }
    public void setId(int id) {
        this.idFuncionario = id;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public void setDocumentoIdentidad(String documentoIdentidad) {
        this.documentoIdentidad = documentoIdentidad;
    }

    public void setCargo(String cargo) {
        this.cargo = cargo;
    }

    public void setCorreo(String correo) {
        this.correo = correo;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }
    
}
