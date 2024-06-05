using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepasoMsm.Utiles
{
    /// <summary>
    /// Clase que contiene metodos que se son utiles para usar a lo largo de la aplicacion
    /// msm - 040624
    /// </summary>
    internal class Utiles
    {

        public static string nombreFicheroLog()
        {
            string ruta = "C:\\Users\\csi23-mserina\\Desktop\\FICHEROS\\log-";
            DateTime fechaHoy = DateTime.Now;
            string fechaString = fechaHoy.ToString("ddMMyyyy");
            string rutaCompleta = String.Concat(ruta, fechaString, ".txt");

            return rutaCompleta;
        }
    }
}
