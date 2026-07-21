
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class csUsuario {

    public csUsuario() {
    }

    public int idUsuario;

    public string nombres;

    public string apellidos;

    public string correos;

    public string telefono;

    public string direccion;

    public string estadoIdentidad;

    public date fechaRegistro;

    public string estado;









    /// <summary>
    /// @return
    /// </summary>
    public abstract void registrar();

    /// <summary>
    /// @return
    /// </summary>
    public abstract boolean autenticar();

    /// <summary>
    /// @return
    /// </summary>
    public void actualizarPerfil() {
        // TODO implement here
        return null;
    }

}