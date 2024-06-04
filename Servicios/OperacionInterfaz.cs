using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepasoMsm.Servicios
{
    /// <summary>
    /// Contiene la cabezera de los metodos del operacion
    /// msm - 040624
    /// </summary>
    internal interface OperacionInterfaz
    {

        /// <summary>
        /// Metodo que se encarga de añadir alumnos
        /// msm - 040624
        /// </summary>
        public void darAltaAlumno();

         
        /// <summary>
        /// Metodo que se encarga de borrar alumnos 
        /// msm - 040624
        /// </summary>
        public void borrarAlumno();

       
        /// <summary>
        /// Metodo que se encarga de mostrar alumnos 
        /// msm - 040624
        /// </summary>
        public void mostrarAlumno();

        
       /// <summary>
       /// Metodo que se encarga de modificar campos de los alumnos 
       /// msm - 040624
       /// </summary>
       public void modificarAlumno();

        /// <summary>
        /// Metodo que modifica los campos del alumno
        /// msm - 040624
        /// </summary>
        /// <param name="campo"></param>
        public void camposAModificar(string campo);
    }
}
