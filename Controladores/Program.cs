using ejercicioRepasoMsm.Dtos;
using ejercicioRepasoMsm.Servicios;

namespace ejercicioRepasoMsm
{
    /// <summary>
    /// Clase principal de la aplicacion 
    /// msm - 040624
    /// </summary>
    class Program
    {

        public static string rutaLog = Utiles.Utiles.nombreFicheroLog();
        public static List<AlumnosDto> listaAlumnos = new List<AlumnosDto>();
        /// <summary>
        /// Metodo que contiene el procedimiento de la aplicacion
        /// msm - 0740624
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) 
        {
        
            int opcionSeleccionada = 0;
            bool cerrarMenu = false;

            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();

            while (!cerrarMenu)
            {
                try
                {
                    opcionSeleccionada = mi.mostrarMenu();
                    switch (opcionSeleccionada)
                    {
                        case 0:
                            using(StreamWriter sw = new StreamWriter(rutaLog, true))
                            {
                                sw.Write("Cerrando Menu\n");
                            }
                            cerrarMenu = true;
                        break;

                        case 1:
                            using (StreamWriter sw = new StreamWriter(rutaLog, true))
                            {
                            
                                sw.Write("Ha seleccionado dar alta alumno\n");
                              
                            }
                            op.darAltaAlumno();
                        break;

                        case 2:
                            using (StreamWriter sw = new StreamWriter(rutaLog, true))
                            {
                               
                                sw.Write("Ha seleccionado borrar alumno\n");
                               
                            }
                            op.borrarAlumno();
                        break;

                        case 3:
                            using (StreamWriter sw = new StreamWriter(rutaLog, true))
                            {
                               
                                sw.Write("Ha seleccionado mostrar alumno\n");
                               
                            }
                            op.mostrarAlumno();
                        break;

                        case 4:
                            using (StreamWriter sw = new StreamWriter(rutaLog, true))
                            {
                               
                                sw.Write("Ha seleccionado modificar alumno\n");
                               
                            }
                            //modificar alumno
                        break;

                        default:
                            Console.WriteLine(" ");
                            Console.WriteLine("Esa opcion no existe");
                            Console.WriteLine(" ");
                            break;

                    }
                }
                catch(Exception ex)
                {
                    using (StreamWriter sw = new StreamWriter(rutaLog, true))
                    {
                        sw.Write("ERROR[]: " + ex.Message + "\n");
                    }
                }
            }
            
        }
    }
}