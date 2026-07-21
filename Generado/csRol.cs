
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class csRol {

    public csRol() {
    }

    public int idRol;

    public string nombreRol;

    public string descripcion;


    /// <summary>
    /// @param u 
    /// @return
    /// </summary>
    public abstract void asignarA(csUsuario u);

}