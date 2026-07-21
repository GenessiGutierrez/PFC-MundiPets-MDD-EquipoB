
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class csSolicitudAdopcion {

    public csSolicitudAdopcion() {
    }

    public int idSolicitudAdopcion;

    public int idPublicacion;

    public int idAdoptante;

    public string justificacion;

    public string condicionesHogar;

    public string estado;

    public date fechaSolicitud;

    public date fechaRespuesta;

    public string motivoCancelacion;
    /// <summary>
    /// @return
    /// </summary>
    public abstract void enviarSolicitud();
    /// <summary>
    /// @return
    /// </summary>
    public abstract void revisar();
    /// <summary>
    /// @return
    /// </summary>
    public abstract void aceptar();
    /// <summary>
    /// @return
    /// </summary>
    public abstract void rechazar();
    /// <summary>
    /// @param motivo 
    /// @return
    /// </summary>
    public abstract void cancelar(string motivo);

}