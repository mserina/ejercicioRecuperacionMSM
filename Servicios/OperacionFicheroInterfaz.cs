using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepasoMsm.Servicios
{
    /// <summary>
    /// Clase que contiene la cabezera de los metodos del servcio de ficheros
    /// msm - 050624
    /// </summary>
    internal interface OperacionFicheroInterfaz
    {
        /// <summary>
        /// Clase que registra los alumnos que se van creando 
        /// msm - 050624
        /// </summary>
        public void escribirAlumnos();

        /// <summary>
        /// Clase que carga los alumnos del fichero
        /// msm - 050624
        /// </summary>
        public void cargaInicial();
    }
}
