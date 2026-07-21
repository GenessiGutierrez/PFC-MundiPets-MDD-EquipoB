
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class csMascota {

    public csMascota() {
    }

    public int idMascota;

    public int idPropietario;

    public string nombre;

    public string especie;

    public string raza;

    public string sexo;

    public int edad;

    public string estadoReproductivo;

    public string descripcion;

    public string estado;







    /// <summary>
    /// @return
    /// </summary>
    public abstract void registrar();

    /// <summary>
    /// @return
    /// </summary>
    public abstract void actualizarEstado();

}