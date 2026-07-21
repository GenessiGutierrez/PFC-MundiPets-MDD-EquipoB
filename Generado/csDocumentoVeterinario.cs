
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class csDocumentoVeterinario {

    public csDocumentoVeterinario() {
    }

    public int idDocumento;

    public int idMascota;

    public int idVeterinario;

    public string tipoDocumento;

    public string urlArchivo;

    public string estadoRevision;

    public string observacionRevision;

    public date fechaCarga;

    public Date fechaRevision;




    /// <summary>
    /// @return
    /// </summary>
    public abstract void cargar();

    /// <summary>
    /// @return
    /// </summary>
    public abstract void revisar();

}