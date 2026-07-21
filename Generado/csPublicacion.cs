
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class csPublicacion {

    public csPublicacion() {
    }

    public int idPublicacion;

    public int idMascota;

    public string tipoPublicacion;

    public string titulo;

    public string descripcion;

    public date fechaPublicacion;

    public string estado;



    /// <summary>
    /// @return
    /// </summary>
    public abstract void crear();

    /// <summary>
    /// @return
    /// </summary>
    public abstract void cambiarEstado();

}