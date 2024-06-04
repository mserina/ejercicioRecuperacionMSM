using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepasoMsm.Servicios
{
    /// <summary>
    /// Interfaz que contiene la cabezera de los metodos del menu
    /// msm - 040624
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu y recoge la respuesta del usuario
        /// msm - 040624
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu();

        /// <summary>
        /// Metodo que muestra el submenu
        /// MSM - 040624
        /// </summary>
        public void logicaMenu2();
    }
}
