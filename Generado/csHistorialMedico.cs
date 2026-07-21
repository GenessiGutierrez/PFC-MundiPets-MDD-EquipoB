
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class csHistorialMedico {

    public csHistorialMedico() {
    }

    public int idHistoria;

    public int idMascota;

    public string enfermedadesPrevias;

    public string alergias;

    public string cirugias;

    public string tratamientos;

    public string observaciones;

    public Date fechaActualizacion;


    /// <summary>
    /// @return
    /// </summary>
    public abstract void actualizar();

    /// <summary>
    /// @return
    /// </summary>
    public abstract void consultar();

}