using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepasoMsm.Servicios
{
    /// <summary>
    ///  Contiene la logica de los metodos del servicio menu 
    /// msm - 040624
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenu()
        {
            int opcionSeleccionada;

            Console.WriteLine("#############################");
            Console.WriteLine("0. Cerrar Aplicacion ");
            Console.WriteLine("1. Dar alta alumno");
            Console.WriteLine("2. Borrar alumno");
            Console.WriteLine("3. Mostrar alumnos");
            Console.WriteLine("4. Modificar alumnos");
            Console.WriteLine("##########################3#");

          
            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
           
            return opcionSeleccionada;
        }
        private int mostrarMenu2()
        {
            int opcionSeleccionada;

            Console.WriteLine("#############################");
            Console.WriteLine("0. Cerrar Aplicacion ");
            Console.WriteLine("1. Nombre");
            Console.WriteLine("2. Apellido1");
            Console.WriteLine("3. Apellido2");
            Console.WriteLine("4. Direccion");
            Console.WriteLine("5. Telefono");
            Console.WriteLine("6. Email");
            Console.WriteLine("7. Fecha nacimiento");
            Console.WriteLine("##########################3#");


            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

            return opcionSeleccionada;
        }

        public void logicaMenu2()
        {
            string rutaLog = Program.rutaLog;
            int opcionSeleccionada = 0;
            bool cerrarMenu = false;

            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();

            while (!cerrarMenu)
            {
                try
                {
                    opcionSeleccionada = mostrarMenu2();
                    switch (opcionSeleccionada)
                    {
                        case 0:
                            using (StreamWriter sw = new StreamWriter(rutaLog, true))
                            {
                                sw.Write("Cerrando Menu\n");
                            }
                            cerrarMenu = true;
                        break;

                        case 1:
                            using (StreamWriter sw = new StreamWriter(rutaLog, true))
                            {

                                sw.Write("Ha seleccionado nombre\n");
                                
                            }
                            
                        break;

                        case 2:
                            using (StreamWriter sw = new StreamWriter(rutaLog, true))
                            {

                                sw.Write("Ha seleccionado borrar apellido\n");

                            }
                           
                        break;

                        case 3:
                            using (StreamWriter sw = new StreamWriter(rutaLog, true))
                            {

                                sw.Write("Ha seleccionado mostrar apellido2\n");

                            }
                            
                        break;

                        case 4:
                            using (StreamWriter sw = new StreamWriter(rutaLog, true))
                            {

                                sw.Write("Ha seleccionado modificar direccion\n");

                            }
                            
                        break;

                        case 5:
                            using (StreamWriter sw = new StreamWriter(rutaLog, true))
                            {

                                sw.Write("Ha seleccionado modificar telefono\n");

                            }
                            //modificar alumno
                        break;

                        case 6:
                            using (StreamWriter sw = new StreamWriter(rutaLog, true))
                            {

                                sw.Write("Ha seleccionado modificar email\n");

                            }
                            //modificar alumno
                        break;

                        case 7:
                            using (StreamWriter sw = new StreamWriter(rutaLog, true))
                            {

                                sw.Write("Ha seleccionado modificar fecha nacimiento\n");

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
                catch (Exception ex)
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
