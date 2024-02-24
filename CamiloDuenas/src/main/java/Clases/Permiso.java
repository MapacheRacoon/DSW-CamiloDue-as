/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Clases;

/**
 *
 * @author cadd9
 */
public class Permiso extends Funcionario {
    
    public String NombreCompleto;
    public String FechaInicio;
    public String FechaFin;
    public String Motivo;
    public String Estado;

    public Permiso(int idFuncionario, String NombreCompleto, String FechaInicio, String FechaFin, String Motivo, String Estado, int id, String nombre, String apellido, String documentoIdentidad, String cargo, String correo, String telefono) {
        super(id, nombre, apellido, documentoIdentidad, cargo, correo, telefono);
        this.idFuncionario = idFuncionario;
        this.NombreCompleto = NombreCompleto;
        this.FechaInicio = FechaInicio;
        this.FechaFin = FechaFin;
        this.Motivo = Motivo;
        this.Estado = Estado;
    }

    public void setNombreCompleto(String NombreCompleto) {
        this.NombreCompleto = NombreCompleto;
    }

    public void setFechaInicio(String FechaInicio) {
        this.FechaInicio = FechaInicio;
    }

    public void setFechaFin(String FechaFin) {
        this.FechaFin = FechaFin;
    }

    public void setMotivo(String Motivo) {
        this.Motivo = Motivo;
    }

    public void setEstado(String Estado) {
        this.Estado = Estado;
    }
    
}
